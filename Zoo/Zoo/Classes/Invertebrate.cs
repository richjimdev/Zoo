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
        public override bool Spine { get; set; } = false;
    }
}
