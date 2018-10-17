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
        //New regular Property
        public string Domain { get; set; } = "Eukaryota";

        //New abstract method
        public abstract string Nutrition();

        //New abstract property
        public abstract bool Spine { get; set; }
    }
    
}
