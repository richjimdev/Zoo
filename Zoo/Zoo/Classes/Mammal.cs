using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract class derrived from Vertebrate
    /// </summary>
    public abstract class Mammal : Vertebrate
    {
        //overriding abstract property
        public override string Blood { get; set; } = "warm";

        //new virtual method for optional override
        public virtual bool LaysEggs { get; set; } = false;

    }
}
