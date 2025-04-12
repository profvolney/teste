# -*- coding: utf-8 -*-

"""
Copyright: LAViD - Laboratório de Aplicações de Vídeo Digital
Author: André Araújo <andre.araujo@lavid.ufpb.br>
File: vlibras.py
Date: 21/02/2017
Version: 1.0.0
"""

import logging
import os
import queue
import socket
import threading
import time
import sys


RELEASE = True


class Logger(object):

    def __init__(self, **kwargs):
        object.__init__(self)
        self.__logname = str(kwargs.get("logname", __name__))
        self.__logwrite = bool(kwargs.get("logwrite", True))
        self.__loglevel = int(kwargs.get("loglevel", logging.NOTSET))
        self.__logpath = os.path.splitext(__file__)[0] + ".log"
        self.__logformat = "[%(asctime)s] %(levelname)s %(funcName)s %(lineno)s: %(message)s"
        self.log = logging.getLogger(self.__logname)
        self.log.setLevel(self.__loglevel)
        if (self.__logwrite):
            self.filehandler = logging.FileHandler(self.__logpath)
            self.filehandler.setFormatter(logging.Formatter(self.__logformat))
            self.filehandler.setLevel(self.__loglevel)
            self.log.addHandler(self.filehandler)
        logging.basicConfig(format=self.__logformat)


logHandler = None

if (RELEASE):
    logHandler = Logger(loglevel=logging.WARNING)
else:
    logHandler = Logger(loglevel=logging.INFO, logwrite=False)

translate = False

try:
    cwd = os.path.dirname(os.path.abspath(__file__))
    sys.path.append(cwd)
    import vlibras_translate
    translate = True
except Exception as e:
    logHandler.log.error("Tradutor can not be used")
    logHandler.log.error(repr(e))


q = queue.Queue(1000)


class ClientPlayer(threading.Thread):

    global logHandler, translate, q

    def __init__(self, addr):
        threading.Thread.__init__(self)
        self.__connected = False
        self.__addr = addr
        self.__data = ""
        self.__sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.__sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.__sock.settimeout(None)

    def run(self):
        while True:
            try:
                if (not self.__connected):
                    q.queue.clear()
                    logHandler.log.debug("Connecting with Player [%s:%d]" % (self.__addr[0], self.__addr[1]))
                    self.__sock = socket.create_connection(self.__addr)
                    self.__connected = True
                    logHandler.log.warning("Connection started with Player [%s:%d]" % (self.__addr[0], self.__addr[1]))
                else:
                    while q.qsize() > 0:
                        self.__data = q.get()
                        if (translate):
                            try:
                                self.__translator = vlibras_translate.translation.Translation()
                                self.__translated = self.__translator.rule_translation(self.__data.decode('utf-8', 'strict'))
                                self.__data = " ".join(self.__translated.split())
                            except Exception as e:
                                logHandler.log.error("Error while translate")
                                logHandler.log.error(repr(e))
                        try:
                            if (self.__sock.sendto(self.__data.encode('utf-8', 'strict'), self.__addr)):
                                logHandler.log.info("Sent: [%s]" % (self.__data))
                        except:
                            self.__connected = False
                            logHandler.log.debug("Connection canceled by Player: [%s:%s]" % (self.__addr[0], self.__addr[1]))
                            break
            except:
                self.__connected = False
                self.__sock.close()
                logHandler.log.debug("Connection was closed by Player: [%s:%d]" % (self.__addr[0], self.__addr[1]))
            time.sleep(2)


class ClientNVDA(threading.Thread):

    global logHandler, q

    def __init__(self, addr):
        threading.Thread.__init__(self)
        self.__connected = False
        self.__addr = addr
        self.__data = ""
        self.__maxbuff = 4096
        self.__sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        self.__sock.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
        self.__sock.settimeout(None)

    def run(self):
        while True:
            try:
                if (not self.__connected):
                    logHandler.log.debug("Connecting with NVDA [%s:%d]" % (self.__addr[0], self.__addr[1]))
                    self.__sock = socket.create_connection(self.__addr)
                    self.__connected = True
                    logHandler.log.warning("Connection started with NVDA [%s:%d]" % (self.__addr[0], self.__addr[1]))
                else:
                    self.__data = True
                    while self.__data:
                        try:
                            self.__data = self.__sock.recv(self.__maxbuff)
                            if (self.__data):
                                logHandler.log.info("Recv: [%s]" % (self.__data))
                                if not q.full():
                                    q.put(self.__data)
                        except:
                            self.__connected = False
                            logHandler.log.debug("Connection canceled by NVDA: [%s:%s]" % (self.__addr[0], self.__addr[1]))
                            break
            except:
                self.__connected = False
                self.__sock.close()
                logHandler.log.debug("Connection was closed by NVDA: [%s:%d]" % (self.__addr[0], self.__addr[1]))
            time.sleep(2)


def main():
    global logHandler
    clientPlayer = ClientPlayer(("127.0.0.1", 10000))
    clientPlayer.daemon = True
    clientPlayer.start()
    clientNVDA = ClientNVDA(("127.0.0.1", 10001))
    clientNVDA.daemon = True
    clientNVDA.start()
    clientPlayer.join()
    clientNVDA.join()
    return


if __name__ == "__main__":
    main()
