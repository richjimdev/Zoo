using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract class derrived from Invertebrate, with ILayEggs interface
    /// </summary>
    public abstract class Crustacean : Invertebrate, ILayEggs
    {
        //regular property
        public bool Exoskelleton { get; set; } = true;

        //Filling required method from interface
        public bool LayEggs()
        {
            return true;
        }
    }
}
