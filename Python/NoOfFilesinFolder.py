import os
import sys
import datetime
from colorama import init,Fore

init(convert=True)

arglen = len(sys.argv)
print(Fore.GREEN + "Then name of the file is:" + sys.argv[0])
print(Fore.GREEN + "File execution time:" + str(datetime.datetime.now())) 
if(arglen > 1):
    print(Fore.GREEN + "The provided folder path is:" + sys.argv[1])
    FPath = sys.argv[1]
else:
    print(Fore.RED + "Please pass folder path as first argument!")
    exit()

class FileUtils:
    def GetFilesCount(self,FolderPath):
        filecount = 0
        folder = FolderPath
        for file in os.listdir(folder):
            if os.path.isfile(folder + "\\" + file):
                filecount += 1

        print(Fore.BLUE + "No of files in folder " + folder + " are " + str(filecount))

fu = FileUtils()
fu.GetFilesCount(FPath)
