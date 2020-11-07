"""
В-31
Задане дійсне число x. 
Обчислити натуральний логарифм: (ln(x+1))/x розкладеный за рядом Меркатора.
"""

x = float(input("Enter x: "));
            
e = 0.000001
nCounter = 2
prevResult = 0.0
result = 1.0
while abs(result - prevResult) > e:
    prevResult = result;
                
    result += (-1)**(nCounter + 1) * x**(nCounter - 1)/nCounter;
                
    nCounter += 1;
            
print("Result: %0.6f" % (result));