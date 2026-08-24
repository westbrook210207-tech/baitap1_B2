def ex1():
    y = float(input("Please enter a number from -5 to 5: "))
    while True:
        if -5 <= y <= 5:
            x = y**2 + 2*y + 1
            print(x)
            break
        else:
            print("Please enter a valid number: ")
            y = int(input())

def ex2(symbol):
    vowel = ["u","i","e","o","a"]
    digit = list(range(10))
    if symbol in vowel:
        print(f"{symbol} is a vowel")
    elif symbol in digit:
        print(f"{symbol} is a digit")
    else:
        print(f"{symbol} is other symbol")


import math
def ex3(a,b,c):
    if a == 0:
        if b == 0:
            if c ==0:
                print("vo so nghiem")
            else:
                print("Vo ly")
        else:
            x = (-c)/b
            print(f"Pt co nghiem: x= {x}")
    else:
        delta = b**2 - (a*c)
        if delta > 0:
            x1 = (b-math.sqrt(delta))/(2*a)
            x2 = (b+math.sqrt(delta))/(2*a)
            print(f"Pt co 2 nghiem phan biet: x1 = {x1}, x2 = {x2}")
        elif delta == 0:
            x1 = (-b)/(2*a)
            print(f"pt co nghiem kep: x = {x1}")
        else:
            print("Pt vo nghiem")

ex3(0,1,2)