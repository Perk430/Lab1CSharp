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
            // Dislaying a simple greeting
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!  \n"); 

            // Identifying the variables to be used in the calculations

            double length;
            double width;
            double height;
            double area;
            double perimeter;
            double volume;
            string response = "Y";

            do //Ensuring the code is run at least once

            {
                // Getting input from the user.
                Console.WriteLine("Please enter the length of the room: \n");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the room: \n");
                width = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the height of the room: \n");
                height = double.Parse(Console.ReadLine());

                // Calculating the area of the room

                area = length * width;

                Console.WriteLine("The area of the room is: " + area + " square units \n");

                // Calulating the perimeter of the room

                perimeter = 2 * length + 2 * width;

                Console.WriteLine("The perimeter of the room is: " + perimeter + " units \n");

                // Calculating the volume of the room

                volume = length * width * height;

                Console.WriteLine("The volume of the room is: " + volume + " cubic units \n\n");

                // Prompting to continue to measure rooms

                Console.WriteLine("Would you like to continue? (Y/N)");
                 
                response = Console.ReadLine();
            } while (response.ToUpper() != "N");            
        }
    }
}
