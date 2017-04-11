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

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");

            // Getting input from user

            double length;

            double width;

            double area;

            double perimeter;

            string response = "Y";

            do

            {

                Console.WriteLine("Please enter the length of the room: ");
                length = double.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the width of the room: ");
                width = double.Parse(Console.ReadLine());

                // Calculating the area of the room

                area = length * width;

                Console.WriteLine("The area of the room is: " + area + " square units");

                // Calulating the perimeter of the room

                perimeter = 2 * length + 2 * width;

                Console.WriteLine("The perimeter of the room is: " + perimeter + " units");

                // Prompting to continue to measure rooms

                Console.WriteLine("Would you like to continue? (Y/N)");
                

                response = Console.ReadLine();
            } while (response.ToUpper() != "N");            
        }
    }
}
