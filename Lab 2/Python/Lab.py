"""
В-19
Задані дійсні числа x, y. Визначити, чи належить точка з координатами (x, y)
заштрихованій частині площини:
"""

x = float(input("Input x: "))
y = float(input("Input y: "))
result = False
if ( not(x < 0 and y > 0)):
    if (abs(x) <= 3 and abs(y) <= 3):
        outCircle = x ** 2 + y ** 2
        result = (outCircle >= 9)
        
if(result):
    print("Area contains point.")
else:
    print("Area does not contain point.")