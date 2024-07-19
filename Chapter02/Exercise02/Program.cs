using System;
using static System.Console;
WriteLine("----------------------------------");
            WriteLine("{0,-20} {1,-20} {2,20} {3,20}",
                      "Type",
                      "Bytes of Memory",
                      "Min",
                      "Max");
WriteLine("----------------------------------");
            WriteLine("{0,-20} {1,-20} {2,20} {3,20}",
                      "Int",
                      sizeof(int),
                      int.MinValue,
                      int.MaxValue);