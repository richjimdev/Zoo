using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    //Inherited from Animal, base class to more abstract classes
    public abstract class Vertebrate : Animal
    {
        //Creating new abstract property
        public abstract string Blood { get; set; }

        //Creating a virtual method for optional overriding
        public virtual string Sound()
        {
            return null;
        }

        //Overriding parent abstract property
        public override bool Spine { get; set; } = true;
    }
}
