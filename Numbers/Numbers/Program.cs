using System.Formats.Asn1;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //unsigned integer means positive whole number or 0
            uint naturalNumber = 23;

            int integerNumber = -23;


            //float means single-precision floating point; F suffix makes it a float literal
            float realNumber = 2.2f;

            //double is the default type for a number value with a decimal point
            double anotherRealNumber = 2.3;

            // with c#7.0 you can use an underscore _ character into the digits of number literals to make them more legible
            int bigNumber = 100_000_000;
            Console.WriteLine(bigNumber);


            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;


            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");


            Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");

            Console.WriteLine($"double uses  {sizeof(double)} btyes and can store numbers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");

            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store numbers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}");



            /***
             * 
             * double is not guaranteed to be accurate because some numbers like 0.1 literally cannot be represented as floating-point values
             * only use double when accuracy (such as comparing two numbers) isn't important
             */

            Console.WriteLine("Using doubles:");

            double a = 0.1;
            double b = 0.2;

            if (a + b == 0.3) {

                Console.WriteLine($"{a} + {b} equals {0.3}");
            }

            else {

                Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
            }



            Console.WriteLine("Using decimals:");

            decimal c = 0.1M; // M suffix means a decimal is literal
            decimal d = 0.2M;

            if (c + d == 0.3M)
            {

                Console.WriteLine($"{c} + {d} equals {0.3M}");
            }

            else
            {

                Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
            }





        }
    }
}
