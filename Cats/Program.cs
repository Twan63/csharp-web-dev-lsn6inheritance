using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Cats
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat C = new Cat(12.5);
            HouseCat Garfield = new HouseCat("Garfield", 24);

            List<Cat> aptCats = new List<Cat>();

            aptCats.Add(C);

            //this is casting
            //asigning a varibleName to a Class object 
            Cat madCat = Garfield;
            aptCats.Add(madCat);

            //lets loop through all of the aptcats and let them make a noise 
               //class //obj in class //apt cat list
            foreach (Cat cat in aptCats)
            {
                Console.WriteLine(cat.Noise());
            }



          /*  // Try out your skills with inheritance here!
            HouseCat Garfield = new HouseCat("Garfield", 24);
            //Garfield.Eat();
            Console.WriteLine(Garfield.Tired);// prints false cause garfield did not eat 

            //this will not work because this asks for the constructor in the base class 
            //HouseCat mittens = new HouseCat(8.4);

            Console.WriteLine(Garfield.Weight);

            //Cat plainCat = new Cat(8.6);
            HouseCat cheshireCat = new HouseCat("Cheshire Cat", 26.8);

            // Console.WriteLine(plainCat.Noise());
            // Console.WriteLine(cheshireCat.Noise());

            cheshireCat.Eat();
            cheshireCat.Sleep();
            Console.WriteLine(cheshireCat.Noise());

            Cat Suki = new HouseCat("Suki", 8);

            Suki.Noise();

            Console.Write(Suki.Noise());

            //Will not work because Suki this method is not accessible to the class Cat because isSatisfied is not a Cat method 
            // Suki.IsSatisfied();

            //WILL WORK as long as Suki is really a housecat 
            (Suki as HouseCat).IsSatisfied();

            Suki.Eat();

            Console.WriteLine("Is Suki Tired:", Suki.Sleep());
*/
        }
    }
}
