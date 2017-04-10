using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
                // Welcome Message
                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("");
                Console.WriteLine("");


                // Declare Variables
                float length = 0.0f;
                float width = 0.0f;
                float area = 0.0f;
                float perimeter = 0.0f;
                string Continue = "";


                // Loop if User Chooses to Continue
                while (true)
                {


                // User Input
                Console.WriteLine("Please Enter the Length: ");
                Console.WriteLine("");

                while(!float.TryParse(Console.ReadLine(), out length))
                {
                    Console.WriteLine("Please Enter the Length of the Classroom Using Numbers and/or Decimals.");
                }

                Console.WriteLine("Please Enter the Width: ");
                Console.WriteLine("");

                while (!float.TryParse(Console.ReadLine(), out width))
                {
                    Console.WriteLine("Please Enter the Width of the Classroom Using Numbers and/or Decimals.");
                }


                // Process
                area = length * width;

                perimeter = 2 * (length + width);


                // Output
                Console.WriteLine("The Area of the Classroom is: " + area);

                Console.WriteLine("");

                Console.WriteLine("The Perimeter of the Classroom is: " + perimeter);


                //Continue Loop
                while (true)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Continue?  (y/n)");
                    Continue = Console.ReadLine().ToUpper();
                    Console.WriteLine("");
                    if (Continue == "Y")
                        break;

                    if (Continue == "N")
                        return;

                    else
                        Console.WriteLine("Please Enter Y or N");
                }
            }
        }
    }
}
