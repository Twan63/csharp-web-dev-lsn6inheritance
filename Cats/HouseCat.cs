using System;

namespace Cats
{
    public class HouseCat : Cat
    {
        public string Name { get; set; }
        public string Species { get; } = "Felis catus";


        public HouseCat(string name, double weight) : base(weight)
        {
            Console.WriteLine("Create cat with weight " + name);
            Name = name;
        }

        // On this line, write a constructor that uses the no-arg constructor in the Cat class.

        public bool IsSatisfied()
        {
            return !Hungry && !Tired;
        }

        //this overides the noise method in the Parent class Cat and replaces it with new return  
        public override string Noise()
        {
            if (IsSatisfied())
            {
                return "Hello, my name is " + Name + "!"; // return this string if the cat has eaten and is satisfied 

            }
            else
            {
                return base.Noise();// prints meow 
            }
        }

        public string Purr()
        {
            return "I'm a housecat";
        }
    }
}
