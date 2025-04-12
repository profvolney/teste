# Este codigo serve para juntar as funcionalidades do Drag e do Tradutor pelo VLibras
# para execucao em um unico processo.
# Os print() servem para redirecionar a saida durante a integracao com o c#.

from Clipboard import clip
import vlibras_translate
import requests
import sys
import codecs

# Garantir que o stdout é utf-8
sys.stdout = codecs.getwriter("utf-8")(sys.stdout.detach())

URL = 'https://traducao2.vlibras.gov.br/translate'

def w1(msg):
    file = open('logClipboardAndTranslate.txt', 'a+', encoding='utf8')
    file.write(str(msg))  # t.encode('utf-8', 'ignore'))
    file.close()


try:
    c = clip()
    try:
        response = requests.post(url=URL, json={ "text": c }, timeout=30)
        if response.status_code == 200:
            glosa = response.text
        else:
            raise Exception('Não foi possível fazer a tradução')
    except:
        tradutor = vlibras_translate.translation.Translation()
        glosa = tradutor.rule_translation(c)
    print(glosa + ' ')
    w1('Retorno de clip():\n' + c + '\n\n')
    w1('Retorno de traduzir():\n' + glosa + '\n\n')
except IndexError as ie:
    print(c.upper() + ' ')
    w1('Clip(): ' + c.upper() + '.\n')
    w1('IndexError: ' + str(ie) + '.\n')
except Exception as e:
    w1('Erro:\n' + str(e) + '.\n')
finally:
    quit()
