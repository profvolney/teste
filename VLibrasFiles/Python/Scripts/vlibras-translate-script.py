#!c:\python36\python.exe
# EASY-INSTALL-ENTRY-SCRIPT: 'vlibras-translate==1.1.1','console_scripts','vlibras-translate'
__requires__ = 'vlibras-translate==1.1.1'
import re
import sys
from pkg_resources import load_entry_point

if __name__ == '__main__':
    sys.argv[0] = re.sub(r'(-script\.pyw?|\.exe)?$', '', sys.argv[0])
    sys.exit(
        load_entry_point('vlibras-translate==1.1.1', 'console_scripts', 'vlibras-translate')()
    )
