using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete class derrived from Crustacean
    /// </summary>
    public class Crab : Crustacean
    {
        //overriding method from parent class
        public override string Nutrition()
        {
            return "Algae";
        }
    }
}
