using static System.Console;
int a = 3;
int b = a++;
WriteLine($"a is {a} and b is {b}");
// The variable b has the value 3 because the ++ operator executes after the 
// assignment; this is known as a postfix operator. If you need to increment 
// before the assignment, then use the prefix operator
int c = 3;
int d = ++c;
WriteLine($"c is {c}, d is {d}");
// Due to confusion between prefix, postfix for increment, decrement operators when combined with
// assignment, Swift programming lang designers decided to drop support for this operator in version 3.
// in C# is to never combine use of ++ and -- operators with an assignment operator, =. Perform operations as separate statements
int e = 11;
int f = 3;
WriteLine($"e is {e}, f is {f}");
WriteLine($"e + f = {e + f}");
WriteLine($"e - f = {e - f}");
WriteLine($"e * f = {e * f}");
WriteLine($"e / f = {e / f}");
WriteLine($"e % f = {e % f}");

double g = 11.0;
WriteLine($"g is {g:N1}, f is {f}");
WriteLine($"g/f = {g/f}");

int p = 6;
WriteLine($"p += 3 = {p += 3}"); // equivalent to p = p + 3;
WriteLine($"p -= 3  = {p -= 3}"); // equivalent to p = p - 3;
WriteLine($"p *= 3 = {p *= 3}"); // equivalent to p = p * 3;
WriteLine($"p /= 3 = {p /= 3}"); // equivalent to p = p / 3;
