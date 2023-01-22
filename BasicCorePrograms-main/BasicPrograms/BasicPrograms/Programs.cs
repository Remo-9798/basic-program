using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BasicPrograms
{
     class Programs
    {
        public void VowelandConsonant()
        {
            Console.WriteLine("Enter the character :");
            char ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Albhabet is Vowel");
                    break;
                default:
                    Console.WriteLine("Albhabet is Consonant");
                    break;

            }

        }

        public void FlipCoin()
        {
            Console.WriteLine("Enter the number of flip of coin");
            int Num = int.Parse(Console.ReadLine());
            int headcount = 0;
            int tailcount = 0;

            for (int i = 0; i < Num; i++)
            {
                Random random = new Random();
                float flipcoin = random.Next(0, 2);
                if (flipcoin < 0.5)
                {
                    Console.WriteLine("Coin is tail");
                    tailcount++;
                }
                else
                {
                    Console.WriteLine("Coin is head");
                    headcount++;
                }

            }
            Console.WriteLine("number of heads : " + headcount);
            Console.WriteLine("number of tails : " + tailcount);
            float HeadPercent;
            float TailPercent;

            HeadPercent = (headcount * 100) / Num;
            Console.WriteLine("Percentage of Head :" + HeadPercent);
            TailPercent = 100 - HeadPercent;
            Console.WriteLine("percentage of Tail :" + TailPercent);
        }
        public void LeapYear()
        {
            Console.WriteLine("Enter the year");
            int Year = int.Parse(Console.ReadLine());
            if (Year >= 1000 && Year <= 9999)
            {
                if ((Year % 4 == 0 && Year != 100) || (Year % 400 == 0))
                {
                    Console.WriteLine(" It is a Leap Year");
                }
                else
                {
                    Console.WriteLine(" It is not a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Invalid year");
            }
        }

        public void PowerOfTwo()
        {
            Console.WriteLine("Enter the Power ");
            int Num = int.Parse(Console.ReadLine());

            if (0 <= Num && Num < 31)
            {
                for (int i = 1; i <= Num; i++)
                {
                    Console.WriteLine("2^" + i + "=" + Math.Pow(2, i));
                }
            }
            else
            {
                Console.WriteLine("Exceed the range of integer datatype");
            }
        }

        public void harmonicnumber()
        {
            Console.WriteLine("Enter Number");
            int Num = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 1; i <= Num; i++)
            {
                Console.WriteLine("1/{0}+", i);
                sum += 1 / (float)i;
            }
            Console.Write("\n");
            Console.WriteLine("Harmonic Value is :" + sum);
        }

        public void factor()
        {
            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} Prime Factors is =", Num);
            for (int i = 1; i <= Num; i++)
            {
                if (Num % i == 0)
                {
                    Console.WriteLine(i + " is a factor of "+ Num );

                }
            }
        }


        public void QuotientAndRemainder()
        {
            Console.WriteLine("Enter the Number");
            int Num = int.Parse(Console.ReadLine());
            Console.WriteLine(" Number divided by");
            int Divide = int.Parse(Console.ReadLine());
            int Num1;
            int Num2;

            Num1 = (Num % Divide);
            Console.WriteLine("Remainder of Number = " + Num1);
            Num2 = (Num / Divide);
            Console.WriteLine("Quotient of Number = " + Num2);

        }

        public void SwapNumber()
        {
            Console.WriteLine("Enter Number a : ");
            int Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number b :");
            int Num2 = int.Parse(Console.ReadLine());

            Num1 = Num1 * Num2;
            Num2 = Num1 / Num2;
            Num1 = Num1 / Num2;

            Console.WriteLine("Number after Swapping \n");
            Console.WriteLine("Number a :" + Num1 + " Number b :" + Num2);


        }

        public void EvenAndOdd()
        {
            Console.WriteLine("Enter the number");
            int Num = int.Parse(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine("Number is Even");

            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }

        public void LargestNumber()
        {
            Console.WriteLine("Enter Number a");
            int Num_a=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number b");
            int Num_b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number c");
            int Num_c = int.Parse(Console.ReadLine());
            
            if (Num_a>Num_b && Num_a>Num_c)
            {
                Console.WriteLine("Number a is largest Number");
            }
            else if (Num_b>Num_a && Num_b>Num_c)
            {
                Console.WriteLine("Number b is largest Number");

            }
            else
            {
                Console.WriteLine("Number  is largest Number");

            }
        }






        public static void Main(String[] args)
        {
            Console.WriteLine("1.Flip Coin and print the percentage");
            Console.WriteLine("2.Check wheather year is Leap year or not");
            Console.WriteLine("3.Print table of power of two");
            Console.WriteLine("4.Find the Nth Harmmonic Value");
            Console.WriteLine("5.Print the prime factors of number");
            Console.WriteLine("6.Program to Compute Quotient And Remainder");
            Console.WriteLine("7.Program to Swap Two Numbers");
            Console.WriteLine("8.Check wheather a number is Even or Odd");
            Console.WriteLine("9.Check wheather an Alphabet is Vowel or Consonant");
            Console.WriteLine("10.Find the Largest Among Three Numbers");
            Console.Write("\n");
            Console.WriteLine("Press 1-10 for the coding of the problems ");
            int ans=int.Parse(Console.ReadLine());

            switch(ans)
            {
                case 1:
                    Programs flip = new Programs();
                    flip.FlipCoin();
                    break;
                    case 2:
                    Programs Leap = new Programs();
                    Leap.LeapYear();
                    break;
                case 3:
                    Programs power = new Programs();
                    power.PowerOfTwo();
                    break;
                case 4:
                    Programs Harmonic = new Programs();
                    Harmonic.harmonicnumber();
                    break;
                    case 5:
                    Programs factors = new Programs();
                    factors.factor();
                    break;
                case 6:
                    Programs Quotient = new Programs();
                    Quotient.QuotientAndRemainder();
                    break;
                case 7:
                    Programs swap = new Programs();
                    swap.SwapNumber();
                    break;
                    case 8:
                    Programs Even = new Programs();
                    Even.EvenAndOdd();
                    break;
                case 9:
                    Programs Alphabet = new Programs();
                    Alphabet.VowelandConsonant();
                    break;
                case 10:
                    Programs largest = new Programs();
                    largest.LargestNumber();
                    break;


            }

            
            

            
            
        }
    }

}
