using System;

namespace Cats
{
    public class Cat
    {
        public bool Tired { get; set; } = false;
        public bool Hungry { get; set; } = false;
        public double Weight { get; set; }
        public string Family { get; } = "Felidae";

        //has a single parameter that has a constructor that takes a single parameter of type double
        //this can not generate a new instance because of inheritance 
        public Cat(double weight)
        {
            Weight = weight;
        }

        // On this line, add a no-argument constructor

        public void Sleep()
        {
            Tired = false;
            Hungry = true;
        }

        public void Eat()
        {
            if (!Hungry)
            {
                Tired = true;
            }

            Hungry = false;
        }
        //this overides the method of the same name in the parent Class Cat
        //question why replacing override with abstract breaks the Noise method witin the cat class
        public abstract string Noise()
        {
            return "Meow!";
        }

    }
}
