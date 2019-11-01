using System;

namespace GradeConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grade Converter");
            Console.WriteLine();

            
            Console.WriteLine("Enter a grade");
            String nbrStr = Console.ReadLine();

            int nbr = Convert.ToInt32(nbrStr);

            if (nbr >= 100)
            {
                Console.WriteLine("overachiever");
            }
            else
                if (nbr >= 88)
            {
                Console.WriteLine("You have an A!");

            }
            else
            if (nbr >= 80)
            {
                Console.WriteLine("You have a B");
            }
            else 
            if (nbr >= 67)
            {
                Console.WriteLine("You have a C");
            }
            else
            if (nbr >= 60)
            {
                Console.WriteLine("You have a D");

            }
            else Console.WriteLine("You failed.");
                    }
               
           

        
    }
}
