using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete class derrived from Mammal
    /// </summary>
    public class Lion : Mammal
    {
        //overriding abstract method from 3 levels up
        public override string Nutrition()
        {
            return "meat";
        }

        //overriding virtual method from parent
        public override string Sound()
        {
            return "Roar!";
        }
    }
}
