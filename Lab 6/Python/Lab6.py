def nod2(a,b):
    mod = a % b;
    if (mod == 0):
        return b
    return nod2(b, mod)
    
def nod3(a,b,c):
    return nod2(nod2(a,b),c)
    
inputLine = input("Input 3 nums and separate them using spaces: ").split(' ')
arguments = list(map(int, inputLine))

result = nod3(arguments[0],arguments[1],arguments[2])
print("Result: ",result)