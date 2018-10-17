using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    //New interface for animals that can fly
    interface ICanFly
    {
        //Setting default properties needed fro animals that can fly
        bool wings { get; set; }

        string Fly();
    }
}
