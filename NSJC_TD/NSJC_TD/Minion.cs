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
            //tre�� metody Draw() dla pierwszego typu minion�w
        }
    }
    class Minion:Entity
    {
        private IDrawer Drawer = null;
        double speed;
        double directionAngle;

        public Minion(int type)
        {
            this.type = type;
            if (type == 1)
                Drawer = new Drawer1();

            speed = 0.01;
            directionAngle = 0;
            position.x = 0;
            position.y = 0;
            position.z = 0;
        }
        public override void Update()
        {

        }
        public override void Draw()
        {
            Drawer.Draw();
        }

    }
}
