class validation:
    def Required(self,value,message):
        if (value == ""):
            print(message)

    def CheckIndexExist(self,LenArray,IndexToCheck,message):
        if (IndexToCheck > (LenArray -1)):
            print(message)
            exit() 
