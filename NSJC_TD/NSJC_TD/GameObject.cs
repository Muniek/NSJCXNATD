using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSJC_TD
{
    abstract class GameObject
    {
        abstract public void Update();

        public struct Position
        {
            public double x, y, z;
        }
        public Position position;   //PO ZAKO�CZENIU TEST�W DO POPRAWY - MA BY� PROTECTED
    }
}
