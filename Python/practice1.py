import turtle as t
#turtle test
n = 50
t.bgcolor("black")
t.speed(0)
t.shape("turtle")

for x in range(200):
    if x%3 == 0:
        t.color("red")
    if x%3 == 1:
        t.color("yellow")
    if x%3 == 2:
        t.color("blue")
    t.forward(x*2)
    t.left(119)
