﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    /// <summary>
    /// Abstract class derrived from Vertebrate class
    /// </summary>
    public abstract class Bird : Vertebrate, ICanFly, ILayEggs
    {
        //Override abstract property
        public override string Blood { get; set; }

        //Creating new abstract method for children classes to override
        public abstract int AverageEggsLaid();

        //Implementing properties and methods from our Interfaces
        public string Fly()
        {
            return "I can fly!";
        }

        public bool wings { get; set; } = true;

        public bool layEggs()
        {
            return true;
        }
    }
}
