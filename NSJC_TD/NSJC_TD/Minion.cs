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

        public Minion(int type)
        {
            this.type = type;
            if (type == 1)
                Drawer = new Drawer1();
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
