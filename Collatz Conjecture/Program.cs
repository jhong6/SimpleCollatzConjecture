using System;

namespace Collatz_Conjecture
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple application using Collatz Conjecture to find the number of steps
            //to reach one when n > 1

            //Create a variable to give user the option to keep using the program
            bool flag = true;

            Console.WriteLine("A simple application that uses Collatz Conjecture");

            //Start the application loop
            while(flag)
            {
                //Try user's input after converting to integer
                try
                {
                    Console.WriteLine("Enter a value for n:");
                    int userint = Convert.ToInt32(Console.ReadLine());
                    collatzConj(userint);
                }
                //Let the user know the input must be an integer
                catch (Exception ex)
                {
                    Console.WriteLine("You must input an integer value!");
                }
                //Continue or end the program based on user's input
                finally
                {
                    Console.WriteLine("Continue with the program (n or no to end)?");
                    string userstring = Console.ReadLine();
                    //If user types in n or no, end the loop and exit program
                    if (userstring.ToUpper() == "N" || userstring.ToUpper() == "NO")
                    {
                        flag = false;
                        Console.WriteLine("Ending program...");
                    }
                    //Any other inputs will cause the program to re-run the application
                    else
                    {
                        Console.WriteLine("Continuing...");
                    }
                }
            }
        }
        //Method to execute conjecture
        public static void collatzConj(int n)
        {
            //Declare and initialize variables to count the number of steps
            int steps = 0;
            //check to see if n is greater than 1
            if (n > 1)
            {
                //Loop while n > 1
                while (n > 1)
                {
                    //if n is even, then divide by 2 and add 1 to steps
                    if (n % 2 == 0)
                    {
                        n /= 2;
                        steps += 1;
                    }
                    //if n is odd, multiple n by 3 and add 1, then add 1 to steps
                    else
                    {
                        n = n * 3 + 1;
                        steps += 1;
                    }
                }
                Console.WriteLine("Number of steps: " + steps);
            }
            //Let user know the value must be more than 1
            else
            {
                Console.WriteLine("Value must be greater than 1 for this conjecture.");
            }
        }
    }
}
