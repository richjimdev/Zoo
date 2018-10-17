using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract class derrived from Animal
    /// </summary>
    public abstract class Invertebrate : Animal
    {
        //overriding abstract method derrived from parent
        public override bool Spine { get; set; } = false;
    }
}
