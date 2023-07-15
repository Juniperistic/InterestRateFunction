using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int investment, years; //defining investment & years as integers
            double interestrate;
            double balance = 1000.0;

            String line; //used for reading

            investment = 1000;

            Console.WriteLine("Please enter the interest rate:"); //asking for the input of the interest rate
            {
                line = Console.ReadLine(); //allows the program to read the user input
                interestrate = Convert.ToDouble(line); //converts to a double 
            }

            Console.WriteLine("Please enter the number of years:"); //asking for the input of the number of years 
            {
                line = Console.ReadLine(); //allows the program to read the user input
                years = Convert.ToInt32(line); //converts to an integer
            }

            for (int i = 0; i < years; i++) //when i equals 0 ; i is less than years ; add each year
            {
                balance = balance * (1 + interestrate); //This is the equation balance of 1000 * (1+r)^n 
            }

            Console.WriteLine("The balance after {0} years is {1}", years, balance); //Giving an output to the user for the inputs they have entered using the equation

        }
    }
}
