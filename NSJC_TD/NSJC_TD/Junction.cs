using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSJC_TD
{
    class Junction:GameObject
    {
        List<Minion> listMinions = new List<Minion>();  //lista minionów podpiętych pod dane skrzyżowanie

        public override void Update()
        {
            foreach (Minion minion in listMinions)
            {
                //tutaj zaprogramować co dane skrzyżowanie ma robić z minionem
            }
        }

        public Junction()
        {
            position.x = 40.0;
            position.y = 0;
            position.z = 0;

            Radius = 3.0;
        }
    }
}