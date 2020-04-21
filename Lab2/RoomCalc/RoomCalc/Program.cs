using System;
using System.Linq;

namespace RoomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
                Console.WriteLine("Welcome to Grand Circus Room Calculator!");
            while (proceed.ToLower() == "y")
            {
                //User Input

                Console.WriteLine("Please enter the Length of the room: ");
                string length = Console.ReadLine();

                int stopcheck = 1;
                while (stopcheck == 1) {
                   

                    if (length.All(char.IsDigit))
                    {
                        stopcheck = 0;
                    }
                    else
                    {
                        Console.WriteLine("invalid entry, please try again");
                        Console.WriteLine("Please enter the Length of the room: ");
                        length = Console.ReadLine();
                    }
                                            }
                
                 Console.WriteLine("Please enter the Width of the room: ");
                string width = Console.ReadLine();

                 stopcheck = 1;
                 while (stopcheck == 1) {
                    if (width.All(char.IsDigit))
                    {
                        stopcheck = 0;
                    }
                    else
                    {
                        Console.WriteLine("invalid entry, please try again");
                        Console.WriteLine("Please enter the Width of the room: ");
                        width = Console.ReadLine();
                    }
                }

                //Calculate variable
                double l = double.Parse(length);
                double w = double.Parse(width);
                double h = 84;
                double area = (w * l);
                double perimeter = (w + w + l + l);
                double volume = (w * l * h);

                //Result
                Console.WriteLine();
                Console.WriteLine($"This room has a Area of {area} square inches..");
                Console.WriteLine($" With a Perimeter of {perimeter} inches..");
                Console.WriteLine($" and a Volume of {volume} inches squared.");
                Console.WriteLine();
                //Continue?..
                Console.WriteLine("Would you like to continue calculating rooms? (y/n) ");
                proceed = Console.ReadLine();
                Console.WriteLine();

                //Continue variable
                if (proceed.ToLower() == "y")
                {
                    continue;
                }
                else
                {
                    stopcheck = 1;
                    while (stopcheck == 1) 
                    {
                        if (proceed.ToLower() == "yes")
                        {
                            proceed = "y";
                            stopcheck = 0;
                            continue;
                            
                        }

                        if (proceed.ToLower() == "n")
                        {
                            break;
                        }

                        if (proceed.ToLower() == "no")
                        {
                            break;

                        }
                        else 
                           {
                            Console.WriteLine("invalid entry! please try again.");
                            Console.WriteLine("Would you like to continue calculating rooms? (y/n) ");
                            proceed = Console.ReadLine();
                            Console.WriteLine();

                        }

                        
                    }

                }

                




            }
        }
    }
}
