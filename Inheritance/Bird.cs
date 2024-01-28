using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public bool HasFeathers { get; set; }

        public bool CanFly { get; set; }

        public bool HasLegs { get; set; }
        
        public bool CanWalk { get; set; }


        public void PrintBirdDetails() 
        {
            Console.WriteLine($"Can Fly: {CanFly}");
            Console.WriteLine($"Has Feathers: {HasFeathers}");
            Console.WriteLine($"Has Legs: {HasLegs}");
            Console.WriteLine($"Can Walk: {CanWalk}");
            Console.WriteLine($"Has Eyes: {HasEyes}");
            Console.WriteLine($"Has A Brain: {HasABrain}");
            Console.WriteLine($"Male or female: {MaleOrFemale}");
            Console.WriteLine($"Reproduce: {Reproduce}");
        }
    }
}
