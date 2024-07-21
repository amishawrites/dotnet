using static System.Console;

// namespace WritingFunctions
// {
//     class Program
//     {        // Method to print the times table for a given number
//         static void TimesTable(byte number)
//         {
//             WriteLine($"This is the {number} times table:");
//             for (int row = 0; row <= 12; row++)
//             {
//                 WriteLine($"{row} x {number} = {row * number}");
//             }
//             WriteLine();
//         }

//         // Method to prompt user input and display the times table
//         static void RunTimesTable()
//         {
//             bool isNum;
//             do
//             {
//                 Write("Enter a number between 0 and 255: ");
//                 isNum = byte.TryParse(ReadLine(), out byte number);
//                 if (isNum)
//                 {
//                     TimesTable(number);
//                 }
//                 else
//                 {
//                     WriteLine("Invalid entry. Please try again.");
//                 }
//             } while (isNum);  // Loop to continue prompting until invalid entry
//         }
//         // Main method, entry point of the program
//     }
// }

// Writing a function that returns a value
// namespace WritingFunctions
// {
//     class Program
//     {
//         static decimal CalculateTax(decimal amt, string cntry)
//         {
//             decimal rate;

//             switch (cntry)
//             {
//                 case "CH": // Switzerland 
//                     rate = 0.08M;
//                     break;
//                 case "DK": // Denmark 
//                 case "NO": // Norway
//                     rate = 0.25M;
//                     break;
//                 case "GB": // United Kingdom
//                 case "FR": // France
//                     rate = 0.2M;
//                     break;
//                 case "HU": // Hungary
//                     rate = 0.27M;
//                     break;
//                 case "OR": // Oregon
//                 case "AK": // Alaska
//                 case "MT": // Montana
//                     rate = 0.0M;
//                     break;
//                 case "ND": // North Dakota
//                 case "WI": // Wisconsin
//                 case "ME": // Maine
//                 case "VA": // Virginia
//                     rate = 0.05M;
//                     break;
//                 case "CA": // California
//                     rate = 0.0825M;
//                     break;
//                 default: // most US states 
//                     rate = 0.06M;
//                     break;
//             }
//             return amt * rate;
//         }

//         static void RunCalculateTax()
//         {
//             Write("Enter an amount: ");
//             string amountInText = ReadLine();
//             Write("Enter a two-letter region code: ");
//             string region = ReadLine();
//             if (decimal.TryParse(amountInText, out decimal amount))
//             {
//                 decimal taxToPay = CalculateTax(amount, region);
//                 WriteLine($"You must pay {taxToPay} in sales tax.");
//             }
//             else
//             {
//                 WriteLine("You did not enter a valid amount!");
//             }
//         }

//         static void Main(string[] args)
//         {
//             RunCalculateTax();
//         }
//     }
// }

/// <summary>
/// Pass a 32-bit integer and it will be converted into its ordinal equivalent.
/// </summary>
/// <param name="no">Number is a cardinal value e.g. 1, 2, 3, and so on.</param>
/// <returns>Number as an ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
 
namespace WritingFunctions{
    class Program{
        static string CardinalToOrdinal(int no){
            switch (no){
                case 11:
                case 12:
                case 13:
                return $"{no}th ";
            default:
            string noastext = no.ToString();
            char lastDigit = noastext[noastext.Length-1];
            string suffix = string.Empty;
            switch (lastDigit){
                case '1':
                suffix = "st";
                break;
                case '2':
                suffix = "nd";
                break;
                case '3':
                suffix = "rd";
                break;
                default:
                suffix = "th";
                break;
            }
            return $"{no}{suffix} ";
            }
        }
        static void RunCardinalToOrdinal(){
            for (int no = 1; no<=40; no++){
                Write($"{CardinalToOrdinal(no) }");
            }
        }
        static void Main(string[] args){
            RunCardinalToOrdinal();
        }
    }
}

// namespace WritingFunctions{
//     class Program{
//         static int Factorial(int number){
//             if (number < 1)
//  {
//  return 0;
//  }
//  else if (number == 1)
//  {
//  return 1;
//  }
//  else
//  {
//  return number * Factorial(number - 1);
//  }
//         }
//         static void RunFactorial(){
//  bool isNumber;
//  do
//  {
//  Write("Enter a number: ");
//  isNumber = int.TryParse(
//  ReadLine(), out int number);
//  if (isNumber)
//  {
//  WriteLine(
//  $"{number:N0}! = {Factorial(number):N0}");
//  }
//  else
//  {
//  WriteLine("You did not enter a valid number!");
//  }
//  }
//  while (isNumber);
// }
        
//         static void Main(string[] args){
//             RunFactorial();
//         }
//     }
// }