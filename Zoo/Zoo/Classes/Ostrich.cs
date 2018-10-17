using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete class derrived from Bird (in my zoo ostriches can fly)
    /// </summary>
    public class Ostrich : Bird
    {
        //Overriding both abtract methods passed from parent classes
        public override int AverageEggsLaid()
        {
            return 40 - 15;
        }

        public override string Nutrition()
        {
            return "leaves";
        }
    }
}
