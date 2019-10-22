from PIL import Image, ImageDraw, ImageOps
import pandas as pd

# img = Image.new('RGB', (rows*img_size, cols*img_size), color = 'red')

    

im = Image.open("pink.png")

# color_blue = (55, 0, 111, 255)
color_blue = (208, 0, 56, 255)

color_range = 5
width = im.width-1
height = im.height-1
print(width)
print(height)
for i in range(width):
    for j in range(height):
        pixel = im.getpixel((i,j))
        
        inRrange = pixel[0] > color_blue[0]-color_range and pixel[0] < color_blue[0]+color_range
        inGrange = pixel[1] < color_blue[1]+color_range
        inBrange = pixel[2] > color_blue[2]-color_range and pixel[2] < color_blue[3]+color_range

        if not (inRrange and inGrange and inBrange):
            im.putpixel((i,j),(255,255,255,255))
    
im.show()
im.save('img_pink.png')