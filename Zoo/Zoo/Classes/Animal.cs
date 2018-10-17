using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// The main Base class for all my classes.
    /// </summary>
    public abstract class Animal
    {
        //Regular Property
        public string Domain { get; set; } = "Eukaryota";

        //Abstract method
        public abstract string Nutrition();

        //Abstract property
        public abstract bool Spine { get; set; }
    }
    
}
