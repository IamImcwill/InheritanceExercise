using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool ColdBlooded {  get; set; }
        public bool ShedsSkin { get; set;}
        public bool IsNocturnal { get; set; }
        public bool IsVenomous { get; set; }

        public void PrintReptileDetails()
        {
            Console.WriteLine($"Cold Blooded: {ColdBlooded}");
            Console.WriteLine($"Sheds Skin: {ShedsSkin}");
            Console.WriteLine($"Is Nocturnal: {IsNocturnal}");
            Console.WriteLine($"Is Venomous: {IsVenomous}");
            Console.WriteLine($"Has Eyes: {HasEyes}");
            Console.WriteLine($"Has A Brain: {HasABrain}");
            Console.WriteLine($"Male or female: {MaleOrFemale}");
            Console.WriteLine($"Reproduce: {Reproduce}");
            
        }
    }
}
