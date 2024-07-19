using static System.Console;
// Formatting using numbered positional arguments
int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
 format: "{0} apples costs {1:C}",
 arg0: numberOfApples,
 arg1: pricePerApple * numberOfApples);

// Formatting using interpolated strings
WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

// N0 format string means a number with thousand separators and no decimal places,
// C format string means currency. Currency format will be determined by the
// current thread. Eg, if you run this code on a PC in the UK, you'll get pounds
string applesText = "Apples";
int applesCount = 1234;
string bananasText = "Bananas";
int bananasCount = 56789;
WriteLine(
 format: "{0,-8} {1,6:N0}",
 arg0: "Name",
 arg1: "Count");
WriteLine(
format: "{0,-8} {1,6:N0}",
 arg0: applesText,
 arg1: applesCount);
WriteLine(
 format: "{0,-8} {1,6:N0}",
 arg0: bananasText,
 arg1: bananasCount);

Write("Type your first name and press ENTER: "); 
string firstName = ReadLine();
Write("Type your age and press ENTER: ");
string age = ReadLine();
WriteLine(
 $"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
arg0: key.Key,
arg1: key.KeyChar,
arg2: key.Modifiers);