from __future__ import print_function
import sys,struct
import numpy as np
from pyvox.models import Vox
from pyvox.writer import VoxWriter



if len(sys.argv)!=2:
    print('Usage: nrrd2txt file.raw')
    exit(1)

line = ""

with open(sys.argv[1],"rb") as f:
    voxels=0
    floats=0
    while True:
        bin=f.read(1)
        if not bin: break
        if str(bin) == ' ':
            print('space')
            break
        floats+=1
        try:
            #se quiser inverter aqui e mostrar os poros, tem que fazer esse breguete
            val= 0 if int(bin) == 1 else 1
            # val=int(bin)
            print(val, end=' ')
        except ValueError:
            pass      # or whatever