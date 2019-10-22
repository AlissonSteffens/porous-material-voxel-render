import numpy as np
from pyvox.models import Vox
from pyvox.writer import VoxWriter

size = 100
f=open("out.dat", "r")
contents =f.read()

pixels = np.fromstring(contents, dtype=np.uint8, sep=' ')
matrix = pixels.reshape((size, size, size))

vox = Vox.from_dense(matrix)

VoxWriter('test_inverted.vox', vox).write()
