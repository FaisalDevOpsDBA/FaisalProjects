import os
print("Hi")

print(os.getcwd())

def GetFilesCount(FolderPath):
        filecount = 0
        folder = r"G:\Faisal\FaisalProjects\angular-tour-of-heroes"
        for file in os.listdir(folder):
                #if os.path.isfile(file):
                # filecount += 1
                print( os.path.isfile(folder + "\\" + file))

        print("No of files in folder " + folder + " are " + str(filecount))

GetFilesCount("C:")
