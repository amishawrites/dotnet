using static System.Console;
Write("Enter a number: ");
string inputin = Console.ReadLine();
if (int.TryParse(inputin, out int number))
{
    if (number % 3 == 0 && number % 5 == 0)
    {
        WriteLine("FizzBuzz");
    }
    else if (number % 3 == 0)
    {
        WriteLine("Fizz");
    }
    else if (number % 5 == 0)
    {
        WriteLine("Buzz");
    }
}