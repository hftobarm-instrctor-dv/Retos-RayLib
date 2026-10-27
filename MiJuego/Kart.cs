using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiJuego
{
    internal class Kart
    {

        public int a = 0;
        public int v = 1;

        public int x = 0;


        public void Actualizar()
        {
            x += v;
        }
        public void Draw()
        {
            //Pintar un sprite en la posición x, 200
            Raylib_cs.Raylib.DrawRectangle(x, 200, 50, 30, Raylib_cs.Color.Red);
        }

        public void Acelerar()
        {
            v++;
        }
    }
}
