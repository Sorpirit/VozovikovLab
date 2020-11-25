n = int(input("Input n: "))

ricghtCounter = 1;
leftCounter = 1;

while (n >> leftCounter > 0):
    leftCounter +=1
            
            
m = 0;
            
while (leftCounter > 0):
    if ((n & 1 << (leftCounter - 1)) > 0):
        m += 1<<(ricghtCounter - 1)

    ricghtCounter += 1
    leftCounter -= 1

print("m: ",m)