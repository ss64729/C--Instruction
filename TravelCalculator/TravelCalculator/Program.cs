using System;

namespace TravelCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
    Console.WriteLine("Welcome to the travel time calculator");
            Console.WriteLine();  // print a blank line

            

           

            String choice = "y";
            while (choice.Equals("y"))
            {
                Console.WriteLine("Enter miles : ");

                String milesString = Console.ReadLine();


                Console.WriteLine("Enter mph: ");
                String mphString = Console.ReadLine();

                double miles = Convert.ToInt32(milesString);
                double mph = Convert.ToInt32(mphString);
                                                          

                double time = miles / mph;
                int hrs = (int)Math.Round(time * 60) / 60;

                Console.WriteLine("Hours is " + hrs + ".");
                Console.WriteLine();

                //      double min = (double)Math.round(time*60)/60;

                double result = time * 60 % 60;
                //         Console.WriteLineln(result);

                int minutes = (int)Math.Round(result);
                Console.WriteLine("Minutes is " + minutes);

                //      60 * remainder = minutes
                //another way to do it  		
                //		double hours = miles/mph;
                //	int min = (int)(hours *60);
                //int hoursInt = min/60;
                //	min %=60;

                Console.WriteLine("Calculate another MPG? (y/n): ");
                choice = Console.ReadLine();
                Console.WriteLine();
            }
        }
    }
}
