"""
В-31
Задані натуральні числа m та n.
Обчислити суму m останніх цифр числа n.
"""


n = int(input("Enter n: "))
m = int(input("Enter m: "))
            
result = 0
for i in range(1,m + 1):
    result +=(n % 10**i) // 10**(i-1)
print("Result: ",result)