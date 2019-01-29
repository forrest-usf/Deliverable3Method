/*
    Author: Matthew Bredahl
    Date: 01/29/2019
    Comments: This C# Console application code demonstrates the use of
              a void method.
*/

using System;

namespace Deliverable3Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type in your name: ");

            try
            {
                string input = Console.ReadLine();
                Name(input);
                Console.WriteLine("Press any key to exit the program . . . ");
                Console.ReadKey(true);
            }//End try

            catch
            {
                Console.WriteLine("An error has occurred");
                Console.WriteLine("Press any key to exit the program and try again . . . ");
                Console.ReadKey(true);
            }//End catch
            
        }//End Main method

        private static void Name(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }//End Name method
    }//End Program class
}//End Deliverable3Method namespace
