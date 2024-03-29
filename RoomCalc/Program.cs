﻿using System;

namespace RoomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            string proceed = "y";
            while (proceed == "y")
            {
                //User Input
                Console.WriteLine("Please enter the Length of the room: ");
                string length = Console.ReadLine();
                double l = double.Parse(length);
                Console.WriteLine("Please enter the Width of the room: ");
                string width = Console.ReadLine();
                double w = double.Parse(width);

                //Calculate variable
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
                Console.WriteLine("Would you like to continue calculating rooms? (y/n) ");
                proceed = Console.ReadLine();
            }
        }
    }
}
