using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Interfaces
{
    /// <summary>
    /// Interface for animals that lay eggs
    /// </summary>
    interface ILayEggs
    {
        //Property that animals that lay eggs will need to implement
        bool LayEggs();
    }
}
