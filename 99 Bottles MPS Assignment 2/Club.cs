using System;

namespace Club
{
    public class Beer
    {
        public void Lime()
        {
            for(int A=99;A>2;)
            {
                Console.WriteLine(A+" bottles of beer on the wall, "+A+" bottles of beer.");A--;
                Console.WriteLine("Take one down and pass it around, "+A+" bottles of beer on the wall."); 
            }
        }
    }
}