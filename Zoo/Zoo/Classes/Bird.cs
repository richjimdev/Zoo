using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract class derrived from Vertebrate class
    /// </summary>
    public abstract class Bird : Vertebrate, ICanFly
    {
        //Override abstract property
        public override string Blood { get; set; }

        //Implementing properties and methods from our Interface
        public string Fly()
        {
            return "I can fly!";
        }

        public bool wings { get; set; } = true;

        //Creating new abstract method for children classes to override
        public abstract int AverageEggsLaid();
    }
}
