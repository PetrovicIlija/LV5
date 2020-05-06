using System;
using System.Collections.Generic;
using System.Text;

namespace drugi
{
    interface IShipable
    {
        double Price { get; }
        double Weight { get; }
        string Description(int depth = 0);
    }

}
