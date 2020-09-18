using System;

using Club;

namespace Bottlesofbeer_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {    
            int B=2;
            while (B>1)
            {
                Beer drink = new Beer();
                drink.Lime();

                Console.WriteLine(B+" bottles of beer on the wall, "+B+" bottles of beer.");B--;                   
                Console.WriteLine("Take one down and pass it around, "+B+" bottle of beer on the wall.");

                int C=1;
                while (C>0)
                {
                    Console.WriteLine(C+" bottle of beer on the wall, "+C+" bottle of beer.");C--;
                    Console.WriteLine("Take one down and pass it around, "+C+" bottles of beer on the wall.");
                }
                
            }
        }
    }
}
