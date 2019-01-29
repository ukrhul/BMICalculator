/* Program Name: LAB 1 ASSIGNMENT (CALCULATION OF BODY MASS INDEX)
 * Programmed By: Group 2 (Rahul, Yashu Aggarwal)
 * Last Updated: January 11, 2017
 * 
 * Description: It is the program for calculating the body mass index of a person by prompting user to   
   input height(inches) & weight(pounds) of a person and
   calculate the BMI by multiplying it with 703 and write the BMI to the console.
   It will then prompt the user to press a key, which will exit the program.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {

        // Declaration:
            // Declare a variable for the height as a double type

            double height;

            // Declare a variable for the weight as a double type

            double weight;

            // Declare a variable for the value of BMI as a double type

            double BMI;

            // Input:
            //The height is provided by the user(in inches) as a double.

            Console.Write("Please enter the person's height in inches: " );
            height = double.Parse(Console.ReadLine());

            // The weight is provided by the user(in pounds) as a double.

            Console.Write("Please enter the person's weight in pounds: ");
            weight = double.Parse(Console.ReadLine());

            //Processing:
            //Processing of input to get the value of BMI
            //   BMI = (weight / (height * height)) * 703

            BMI = weight / (height*height) * 703;

            // Output:
            //"The BMI for a " + height + " inches tall person who weighs " + weight + " pounds is " + BMI

            Console.WriteLine("The BMI for a " + height + " inches tall person who weighs " + weight + " pounds is " + BMI);

            // Prompt the user to "Press a key to exit...."

            Console.WriteLine("Press a key to exit...");
            Console.ReadKey();

        }
    }
}
