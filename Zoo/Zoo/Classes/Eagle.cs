using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    /// <summary>
    /// Concrete class derrived from Bird
    /// </summary>
    public class Eagle : Bird
    {
        //Overriding both abstract methods passed from parent classes
        public override int AverageEggsLaid()
        {
            return 5 + 2;
        }

        public override string Nutrition()
        {
            return "rodents";
        }

        public override string Sound()
        {
            return "Screech!";
        }
    }
}
