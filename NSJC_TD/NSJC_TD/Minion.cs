using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace NSJC_TD
{
    public interface IDrawer
    {
        void Draw();
    }
    public class Drawer1 : IDrawer
    {
        public void Draw()
        {
            //treœæ metody Draw() dla pierwszego typu minionów
        }
    }
    class Minion:Entity
    {
        private IDrawer Drawer = null;
        double speed;
        double directionAngle;
        List<Junction> listJunctions;    //referencja do listy 

        public Minion(int type, List<Junction> listJunctions)
        {
            this.type = type;
            if (type == 1)
                Drawer = new Drawer1();

            speed = 0.5;
            directionAngle = 0;
            position.x = 0;
            position.y = 0;
            position.z = 0;
            Radius = 2.0;

            this.listJunctions = listJunctions;
        }
        public override void Update()
        {
            /* przesuñ koordynaty */
            position.x+=speed*Math.Cos(directionAngle);
            position.y+=speed*Math.Sin(directionAngle);
            /* sprawdŸ czy nie nast¹pi³o zderzenie z którymœ z mediatorów */
            foreach (Junction junction in listJunctions)
            {
                double distance = Math.Sqrt(Math.Pow((junction.position.x - this.position.x), 2) + Math.Pow((junction.position.y - this.position.y), 2));
                if (distance < (this.Radius + junction.Radius))
                    System.Diagnostics.Debug.WriteLine("zderzenie!");
                System.Diagnostics.Debug.WriteLine(distance);
            }
        }
        public override void Draw()
        {
            Drawer.Draw();
        }

    }
}
