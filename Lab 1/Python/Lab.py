#В-5
#Дано дiйсне число M виду ссс.ddd
#Помiняти мiсцями числову та дробову частину мiсцями

print("Введiть дiйсне число:");
            
M = float(input());
            
intPart = int(M);
pointPart = float(M % 1 * 1000);
            
result = pointPart + intPart * 0.001;

print("Результат: %.3f" %result);