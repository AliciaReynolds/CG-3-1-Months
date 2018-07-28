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

            string month = Console.ReadLine();

            if (month == "1")
            {
                Console.WriteLine("January");
            }

            else if (month == "2")
            {
                Console.WriteLine("February");
            }
            else if (month == "3") 
            {
                Console.WriteLine("March");
            }
            else if (month == "4") 
            {
                Console.WriteLine("April");
            }
            else if (month == "5") 
            {
                Console.WriteLine("May");
            }
            else if (month == "6") 
            {
                Console.WriteLine("June");
            }
            else if (month == "7") 
            {
                Console.WriteLine("July");
             }
            else if (month == "8") 
            {
                Console.WriteLine("August");
            }
            else if (month == "9")
            {
                Console.WriteLine("September");
            }
            else if (month == "10")
            {
                Console.WriteLine("October");
            }
            else if (month == "11)")
            {
                Console.WriteLine("November");
            }
            else if (month == "12")
            {
                Console.WriteLine("12");
            }
            else
            {
                Console.WriteLine("Sorry. I do not understand your request.");

            }
            
        


            Console.ReadLine();

        }

    }
}
