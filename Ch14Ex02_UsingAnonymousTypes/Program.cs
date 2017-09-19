using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch14Ex02_UsingAnonymousTypes
{
    class Program
    {
        static void Main(string[] args)//an array of anonymous type objects
        {
            var curries = new[]
            {
                new
                {
                    MainIngredient = "Lamb",
                    Style = "Dhansak",
                    Spiciness = 5
                },
                new
                {
                    MainIngredient = "Lamb",
                    Style = "Dhansak",
                    Spiciness = 5
                },
                new
                {
                    MainIngredient = "Chicken",
                    Style = "Dhansak",
                    Spiciness = 5
                }
            };

            Console.WriteLine(curries[0].ToString());//anonymous type implementation of ToString() outputs the value of each property.
            Console.WriteLine(curries[0].GetHashCode());//anonymous type implementation of GetHashCode() returns an integer unique to the object's state.
            Console.WriteLine(curries[1].GetHashCode());
            Console.WriteLine(curries[2].GetHashCode());
            Console.WriteLine(curries[0].Equals(curries[1]));//returns true: anonymous type implementation of Equals() compares the state of objects.
            Console.WriteLine(curries[0].Equals(curries[2]));//returns false.
            Console.WriteLine(curries[0] == curries[1]);//returns false: the == operator compares object references.
            Console.WriteLine(curries[0] == curries[2]);//returns false.

            Console.ReadKey();
        }
    }
}
