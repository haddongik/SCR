A = {1,2,3,4}
B = {5,6,7,8}

print(A)
print(B)

print(1 in A)
print(len(A))
print(A|B)
print(A&B)

C = {x for x in range(1,11)}
D = {x for x in range(1,11) if x%3 == 0}
print(C)
print(D)

x=int(input("num"))
d=2

while d<=x:
    if x%d == 0:
        print(d)
        x/=d;
    else:
        d+=1
