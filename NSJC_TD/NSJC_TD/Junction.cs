using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NSJC_TD
{
    class Junction:GameObject
    {
        List<Minion> listMinions = new List<Minion>();  //lista minionów podpiêtych pod dane skrzy¿owanie
        double directionAngle;

        

        public override void Update()
        {
            /* sprawdŸ czy nie nast¹pi³o zderzenie z którymœ z mediatorów */
            foreach (Minion minion in listMinions)
            {
                double distance = Math.Sqrt(Math.Pow((minion.position.x - this.position.x), 2) + Math.Pow((minion.position.y - this.position.y), 2));
                if (distance < (this.Radius + minion.Radius))
                    System.Diagnostics.Debug.WriteLine("zderzenie!");
                System.Diagnostics.Debug.WriteLine(distance);
                //tutaj zaprogramowaæ co dane skrzy¿owanie ma robiæ z minionem
            }
        }

        public Junction(double directionAngle, List<Minion> listMinions)
        {
            this.listMinions = listMinions;

            position.x = 40.0;
            position.y = 0;
            position.z = 0;

            Radius = 3.0;

            this.directionAngle = directionAngle;
        }
    }
}