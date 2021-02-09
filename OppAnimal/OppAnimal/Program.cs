using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OppAnimal
{
    class Program
    {
        static void Main(string[] args)
        {
            //Make a tiger and a Caracal
            Species Tiger = new Species("Tiger", "Panthera Tigris");
            Species Caracal = new Species("Caracal");
            Family Felidae = new Family("Felidae");
            Felidae.numberOfTeeth = 30;
            Felidae.numberOfToes = 5;
            Tiger.setAttributes(Felidae);
            Caracal.setAttributes(Felidae);
            Console.WriteLine("What is the name of the species?");
            string newSpieciesName = Console.ReadLine();
            Console.WriteLine("How many legs does it have?");
            int numLegs = int.Parse(Console.ReadLine());

            Species newObj = new Species(newSpieciesName, numLegs);
            Console.ReadLine();
        }
    }
}
