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
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Welcome to the Factorial Calculator!");
                Console.WriteLine("Enter an integer that's greater than 0 but less than 10:");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(n = n * (i));

                }
                run = Continue();
            }

        }


        public static Boolean Continue()
        {
            Boolean run;
            Console.WriteLine("Continue? Y/N");
            String answer = Console.ReadLine();
            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;
                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }


    }
}

