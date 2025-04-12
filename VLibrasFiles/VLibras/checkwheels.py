import pip
import platform
import sys
from shutil import copyfile


modulos =  {"numpy":            "numpy-1.11.2-cp27-none-win32.whl",
            "yaml":             "PyYAML-3.12-cp27-cp27m-win32.whl",
            "win32clipboard":   "pypiwin32-219-cp27-none-win32.whl",
            "winshell":         "winshell-0.6-cp27-none-any.whl",
            "future":           "future-0.15.2-py2-none-any.whl",
            "nltk":             "nltk-3.0.5-py2-none-any.whl",
            "nltk_tgrep":       "nltk_tgrep-1.0.6-py2-none-any.whl",
            "pyparsing":        "pyparsing-2.1.9-py2.py3-none-any.whl",
            "dateutil":         "python_dateutil-2.5.3-py2.py3-none-any.whl",
            "pytz":             "pytz-2016.7-py2.py3-none-any.whl",
            "six":              "six-1.10.0-py2.py3-none-any.whl",
            "matplotlib":       "matplotlib-1.5.3-cp27-cp27m-win32.whl"
            }

def is64bits():
    return platform.machine().endswith('64')
    #return (sys.maxsize > 2**32)

def checaModulo(mod):
    try:
        __import__('imp').find_module(mod)
        print("Modulo "+mod+" encontrado.")
        return True
    except ImportError:
        print("Modulo "+mod+" nao encontrado.")
        return False

def instalarWheel(whl):
    pip.main(['install', "wheels\\"+whl, "--force-reinstall"])

def batchInstalacao(mod, whl, force):
    if force or not checaModulo(mod):
        instalarWheel(whl)

def run(force=False):
    for mod, whl in modulos.iteritems():
        batchInstalacao(mod, whl, force)
    #para impedir que a janela do hunpos.exe se abra, tem que substituir por essa versao
    copyfile(r"wheels\hunpos.py", r"C:\Python27\Lib\site-packages\nltk\tag\hunpos.py")

if __name__ == '__main__':
    if len(sys.argv) > 1:
        force = True
    else:
        force = False
    run(force)
    quit()

    #  if len(sys.argv) > 1 else False
    # run(force)

# if(is64bits()):
#     modulo = "matplotlib"
#     whl = "matplotlib-1.5.3-cp27-cp27m-win_amd64.whl"
#     batchInstalacao(modulo, whl)

#     modulo = "numpy"
#     whl = "numpy-1.11.2-cp27-none-win_amd64.whl"
#     batchInstalacao(modulo, whl)

#     modulo = "yaml"
#     whl = "PyYAML-3.12-cp27-cp27m-win_amd64.whl"
#     batchInstalacao(modulo, whl)

#     modulo = "win32clipboard"
#     whl = "pypiwin32-219-cp27-none-win_amd64.whl"
#     batchInstalacao(modulo, whl)
# else:
#     modulo = "matplotlib"
#     whl = "matplotlib-1.5.3-cp27-cp27m-win32.whl"
#     batchInstalacao(modulo, whl)

#     modulo = "numpy"
#     whl = "numpy-1.11.2-cp27-none-win32.whl"
#     batchInstalacao(modulo, whl)

#     modulo = "yaml"
#     whl = "PyYAML-3.12-cp27-cp27m-win32.whl"
#     batchInstalacao(modulo, whl)

#     modulo = "win32clipboard"
#     whl = "pypiwin32-219-cp27-none-win32.whl"
#     batchInstalacao(modulo, whl)
