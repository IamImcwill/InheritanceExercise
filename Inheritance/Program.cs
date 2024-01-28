using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal DONE!!!!
            // give this class 4 members that all Animals have in common DONE!!!!


            // Create a class Bird DONE!!!!
            // give this class 4 members that are specific to Bird DONE!!!!

            // Create a class Reptile DONE!!!!
            // give this class 4 members that are specific to Reptile DONE!!!!
            // Set this class to inherit from your Animal Class DONE!!!!




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird falcons = new Bird(); 
            
            falcons.CanFly = true;
            falcons.HasABrain = true;
            falcons.HasEyes = true;
            falcons.Reproduce = true;
            falcons.CanWalk = true;
            falcons.HasFeathers = true;
            falcons.HasLegs = true;
            falcons.MaleOrFemale = true;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile snakes = new Reptile();
            snakes.IsNocturnal = true;
            snakes.ShedsSkin = true;
            snakes.HasABrain = true;
            snakes.HasEyes = true;
            snakes.Reproduce = true;
            snakes.ColdBlooded = true;
            snakes.IsVenomous = true;
            snakes.MaleOrFemale = true;


            falcons.PrintBirdDetails();
            Console.WriteLine();
            snakes.PrintReptileDetails();
        }
    }
}
