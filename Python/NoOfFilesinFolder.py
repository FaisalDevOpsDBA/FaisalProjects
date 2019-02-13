import os
""" def CountNumFiles(folder):
    return i+j """

filecount = 0
folder = os.getcwd()
for file in os.listdir(folder):
    if os.path.isfile(file):
        filecount += 1

print("No of files in folder " + folder + " are " + str(filecount))