internal class Program
{
    private static void Main(string[] args)
    {
        uint natural = 23; // positive whole no.
        int integer = -23;
        float realno = 2.3F; // float literal
        double realno2 = 2.3; // double literal

        // decimal number system, known as Base 10,meaning there are ten digits, from 0 to 9
        // binary number system known as Base 2

        // three variables that store the number 2 million
        int decimalNotation = 2_000_000;
        int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
        int hexadecimalNotation = 0x_001E_8480;

        Console.WriteLine($"{decimalNotation == binaryNotation}");
        Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

        // 8 + 4 + ½ + ¼ = 12¾ = 12.75
        Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
        Console.WriteLine($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
        Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");

        // An int var uses 4 bytes of memory and can store +ve or -ve numbers up to about 2 billion. 
        // A double var uses 8 bytes of memory and can store much bigger values! 
        // A decimal var uses 16 bytes of memory and can store big numbers, but not as big as a double type.
        
        Console.WriteLine("Using doubles:");
        double a = 0.1;
        double b = 0.2;
        if (a + b == 0.3)
        {
        Console.WriteLine($"{a} + {b} equals 0.3");
        }
        else
        {
        Console.WriteLine($"{a} + {b} does NOT equal 0.3");
        }
        //The double type is not guaranteed to be accurate because some numbers literally cannot be represented as floating-point values like 0.1
        // only use double when accuracy, especially when comparing the equality of two numbers, is not important
        // Never compare double values using ==
        Console.WriteLine("Using decimals:");
        decimal c = 0.1M; // M suffix means a decimal literal value
        decimal d = 0.2M;
        if (c + d == 0.3M)
        {
        Console.WriteLine($"{c} + {d} equals 0.3");
        }
        else
        {
        Console.WriteLine($"{c} + {d} does NOT equal 0.3");
        }
        // Use int for whole numbers and double for real numbers that will not be compared to other values. 
        // Use decimal for money, CAD drawings, general engineering, and wherever accuracy of a real number is important.
        
        // double.NaN means not-a-number, 
        // double.Epsilon is the smallest positive number that can be stored in a double, and 
        // double.Infinity means an infinitely large value
    }
}