using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Raylib_cs;

namespace Kart
{
    internal class Pelota
    {
        private int x = 0;
        private int y = 0;

        private int velocidad_x = 1;
        private int velocidad_y = 1;

        public void Actualizar()
        {
            x += velocidad_x;
            y += velocidad_y;
            //Si la posicion en y es mayor que 450
            if (y > 450)
            {
                //reverse la velocidad
                velocidad_y *= -1;
            }
            if (x > 800)
            {
                velocidad_x *= -1;
            }

        }

        public void Draw()
        {
            Raylib.DrawCircle(x, y, 20, Raylib_cs.Color.Blue);
        }
    }
}
