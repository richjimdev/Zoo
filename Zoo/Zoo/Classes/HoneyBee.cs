using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete class derrived from Insect, with Interface ICanFly
    /// </summary>
    public class HoneyBee : Insect, ICanFly
    {
        //Filling required properties from Interface
        public bool wings { get; set; } = true;

        public string Fly()
        {
            return "bzzz";
        }

        //overriding derrived abstract method
        public override string Nutrition()
        {
            return "Nectar";
        }
    }
}
