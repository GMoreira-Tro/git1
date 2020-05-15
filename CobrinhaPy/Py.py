import math

def tCalc(x, mu, s, n):
  t = s/ math.sqrt(n)
  t = (x - mu) / t
  return t

print(tCalc(20,24,4,30))