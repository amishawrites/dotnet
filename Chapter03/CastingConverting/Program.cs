using static System.Convert;
using static System.Console;
int a = 10;
double b = a;
WriteLine(b);

double c = 9.8;
int d = (int)c; // compiler gives an error for this line
WriteLine(d);

// Converting also known casting
// Implicit casting happens automatically, it is safe, that you will not lose any information.
// Explicit casting must be performed manually because it may lose information

long e = 10;
int f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

e = 5_000_000_000;
f = (int)e;
WriteLine($"e is {e:N0} and f is {f:N0}");

double g = 9.8;
int h = ToInt32(g);
WriteLine($"g is {g} and h is {h}");

double[] doubles = new[] { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
foreach (double n in doubles){
    WriteLine($"ToInt({n}) is {ToInt32(n)}");
}
// rounds down if the decimal part is less than the midpoint .5.
// rounds up if the decimal part is more than the midpoint .5.
// round up if the decimal part is the midpoint .5 and the non-decimal 
// part is odd, but it will round down if the non-decimal part is even.
// Banker's Rounding

foreach (double n in doubles){
    WriteLine(
        format: "Math.Round({0},0,MidpointRounding.AwayFromZero) is {1}",
        arg0: n,
        arg1: Math.Round(value:n,
        digits:0,
        mode: MidpointRounding.AwayFromZero)
    );
}
// MidpointRounding.AwayFromZero means that when the value is exactly halfway between two integers, 
// it rounds to the nearest integer that is away from zero.
// Eg, 2.5 rounds to 3, and -2.5 rounds to -3

int no = 12;
WriteLine(no.ToString());

bool boolean = true;
WriteLine(boolean.ToString());

DateTime now = DateTime.Now;
WriteLine(now.ToString());

object me = new object();
WriteLine(me.ToString());

// allocate array of 128 bytes
byte[] binaryObject = new byte[128];
// populate array with random bytes
(new Random()).NextBytes(binaryObject);
WriteLine("Binary Object as bytes:");
for(int index = 0; index < binaryObject.Length; index++)
{
 Write($"{binaryObject[index]:X} ");
}
WriteLine();
// convert to Base64 string and output as text
string encoded = Convert.ToBase64String(binaryObject);
WriteLine($"Binary Object as Base64: {encoded}");

int age = int.Parse("127");
DateTime bday = DateTime.Parse("1 jan 2001");
WriteLine($"I was born {age} years ago.");
WriteLine($"My birthday is {bday}.");
WriteLine($"My birthday is {bday:D}.");

// int count = int.Parse("abc");
// Unhandled Exception: System.FormatException: Input string was not in a correct format.

//  TryParse attempts to convert the input string and returns true if it can convert it and false if it cannot
Write("How many eggs are there? ");
int count;
string input = Console.ReadLine();
if (int.TryParse(input, out count))
{
 WriteLine($"There are {count} eggs.");
}
else
{
 WriteLine("I could not parse the input.");
}