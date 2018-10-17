using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// An abstract class derrived from Invertebrate
    /// </summary>
    public abstract class Insect : Invertebrate
    {
        //setting a regular default property
        public int Legs { get; set; } = 6;
    }
}
