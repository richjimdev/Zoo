using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammal : Vertebrate
    {
        //overriding abstract property
        public override string Blood { get; set; } = "warm";

        //new virtual method for optional override
        public virtual bool laysEggs { get; set; } = false;

    }
}
