using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    interface ICanFly
    {
        bool wings { get; set; }

        string Fly();
    }
}
