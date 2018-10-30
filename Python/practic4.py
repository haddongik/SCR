import math
import sys

def 이차방정식(val1, val2, val3):
    print(val1 / val2)

a=float(input("a? "))
b=float(input("b? "))
c=float(input("c? "))

if a==0:
    print("이차방정식X")
    sys.exit()

D = b*b-4*a*c
if D > 0:
    x1 = (-b+math.sqrt(D))/(2*a)
    x2 = (-b-math.sqrt(D))/(2*a)
    print("x1 : %d, x2 : %d", x1,x2)
if D==0:
    x = -b/(2*a)
    print(x)
if D<0:
    print("해가 없음")
