using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSJC_TD
{
    abstract class Entity:GameObject
    {
        protected int type;
        abstract public void Draw();
    }
}
