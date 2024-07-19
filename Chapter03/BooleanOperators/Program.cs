using System;
using static System.Console;
bool a = true;
bool b = false;

WriteLine($"AND | a | b ");
WriteLine($"a | {a & a,-5} | {a & b,-5} ");
WriteLine($"b | {b & a,-5} | {b & b,-5} ");
WriteLine();
WriteLine($"OR | a | b ");
WriteLine($"a | {a | a,-5} | {a | b,-5} ");
WriteLine($"b | {b | a,-5} | {b | b,-5} ");
WriteLine();
WriteLine($"XOR | a | b ");
WriteLine($"a | {a ^ a,-5} | {a ^ b,-5} ");
WriteLine($"b | {b ^ a,-5} | {b ^ b,-5} ");
// AND & logical op, both operands must be true for result to be true. 
// OR | logical op, either operand can be true for result to be true. 
// XOR ^ logical op, either operand can be true (but not both!) for result to be true.
WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}");

WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}"); // DoStuff function was not executed!      

bool DoStuff()
{ WriteLine("I am doing some stuff.");
    return true;
}
// && is logical AND operator with short-circuiting. means if first operand is false, 
// second operand will not be evaluated because result is already determined.
