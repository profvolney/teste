# -- coding: utf-8 --

import ctypes
import os
import subprocess
import win32clipboard

global process

# Copia área de transferência


def clip():

    global process

    path = os.environ['PATH_VLIBRAS']
    subprocess.call(path+"\\bin\\Drag\\Drag.exe")

    win32clipboard.OpenClipboard()
    if win32clipboard.IsClipboardFormatAvailable(
            win32clipboard.CF_UNICODETEXT):
        t = win32clipboard.GetClipboardData(win32clipboard.CF_UNICODETEXT)
        win32clipboard.EmptyClipboard()
        win32clipboard.CloseClipboard()
        return t
    else:
        win32clipboard.EmptyClipboard()
        win32clipboard.CloseClipboard()
        return "ESCOLHER TEXTO CERTO"
