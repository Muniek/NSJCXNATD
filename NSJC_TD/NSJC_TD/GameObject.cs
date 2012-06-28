using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSJC_TD
{
    abstract class GameObject
    {
        abstract public void Update();

        struct Position
        {
            public int x, y, z;
        }
    }
}
