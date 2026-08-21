def sumar(num1, num2):
    total = num1 +num2
    return  total 

def restar(num1, num2):
    return num1 - num2

def mult(x, y):
    mult = x * y
    return mult

def dividir(n, y):
    if(y==0):
        return "no se puede dividir entre 0"

    return n / y


def main():
    num1 = 12 
    num2 = 0 

    print(sumar(num1, num2))
    print(restar(num1, num2))
    print(mult(num1, num2))
    print(dividir(num1, num2))

if _name_ == "_main_":
    main()
