using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!\n");

            long i, number, fact;

            string cont;
            do

            {
                do
                {
                    Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
                    bool result = long.TryParse(Console.ReadLine(), out number);

                    if (number == 0 || number >= 10)
                    {
                        Console.WriteLine("Invalid Data Entered, Please Try Again...");
                    }
                } while (number == 0 || number >= 10);

                //number = int.Parse(Console.ReadLine());
                fact = number;
                for (i = number - 1; i >= 1; i--)
                {
                    fact = fact * i;
                }
                Console.WriteLine("\nThe factorial of " + number + " is: " + fact);

                Console.WriteLine("\nDo you want to continue? (y/n)");
                cont = Console.ReadLine();
                Console.WriteLine("");

            } while (cont.ToLower() == "y" || cont.ToLower() == "yes");

        }
    }
}



//Recursion Method
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4

{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Factorial Calculator!\n");
            int userNum;

            string cont;
            do

            {
                do
                {
                    Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
                    bool result = Int32.TryParse(Console.ReadLine(), out userNum);

                    if (userNum == 0 || userNum >= 10)
                    {
                        Console.WriteLine("Invalid Data Entered, Please Try Again...");
                    }
                } while (userNum == 0 || userNum >= 10);



                // int number = Convert.ToInt32(Console.ReadLine());
                long fact = GetFactorial(userNum);
                Console.WriteLine("The factorial of {0} is {1}", userNum, fact + ".");
                
                Console.WriteLine("\nDo you want to continue? (y/n)");
                cont = Console.ReadLine();
                Console.WriteLine("");

            } while (cont.ToLower() == "y" || cont.ToLower() == "yes");

        }

        private static long GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            else { return number * GetFactorial(number - 1); }

        }

    }
}
*/

/* public long Factorial(int n)
{
 if (n == 0)//The condition that limites the method for calling itself
     return 1;
 return n * Factorial(n - 1);
}

Console.WriteLine("Enter a number");
 int number = Convert.ToInt32(Console.ReadLine());
 long fact = GetFactorial(number);
 Console.WriteLine("{0} factorial is {1}", number, fact);           
 Console.ReadKey();


/*
C# Program to Generate the Factorial of  Given Number 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, number, fact;
            Console.WriteLine("Enter the Number");
            number = int.Parse(Console.ReadLine());
            fact = number;
            for (i = number - 1; i >= 1; i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("\nFactorial of Given Number is: " + fact);
            Console.ReadLine();

        }
    }
}
*/

/*
Alex's Codes:

static void calcFactorial(int userNum)
{ 

long factorialNum = 1;

FOR LOOP

for(int i = 1; i <= userNum; i++)
    {factorialNum = factorialNum* i;}

WHILE LOOP
    int i = 1;
    while (i <= userNum)
    { factorialNum = factorialNum * i; }

 DO_WHILE LOOP
        int i = 1;
    do { factorialNum = factorialNum * i; i++; }
    while (i <= userNum);

 }

*/
