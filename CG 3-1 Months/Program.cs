using System;

namespace CG_3_1_Months
{
    class Program
    {
        static void Main(string[] args)
        {
            /*This is the start of the program, asking the user to input a number to received
             * the corresponding month name.  I'm terrible with starting sentences.*/

            Console.WriteLine("Please input a number 1 thru 12 to find out the corresponding month.");

            /*This allows the program to take inputted data from the user to run*/

            string month = Console.ReadLine();

            //This is the beginning of the 'if' statement, broken up by what number is chosen to correspond with that month

            if (month == "1")
            {
                Console.WriteLine("That month is January.");
            }

            else if (month == "2")
            {
                Console.WriteLine("That month is February.");
            }
            else if (month == "3") 
            {
                Console.WriteLine("That month is March.");
            }
            else if (month == "4") 
            {
                Console.WriteLine("That month is April.");
            }
            else if (month == "5") 
            {
                Console.WriteLine("That month is May.");
            }
            else if (month == "6") 
            {
                Console.WriteLine("That month is June.");
            }
            else if (month == "7") 
            {
                Console.WriteLine("That month is July.");
             }
            else if (month == "8") 
            {
                Console.WriteLine("That month is August.");
            }
            else if (month == "9")
            {
                Console.WriteLine("That month is September.");
            }
            else if (month == "10")
            {
                Console.WriteLine("That month is October.");
            }
            else if (month == "11)")
            {
                Console.WriteLine("That month is November.");
            }
            else if (month == "12")
            {
                Console.WriteLine("That month is December.");
            }
            else
            {
                Console.WriteLine("Sorry. I do not understand your request.");

            }
            
        //Is there a way to make all ^^^that shorter?


            Console.ReadLine();

        }

    }
}
