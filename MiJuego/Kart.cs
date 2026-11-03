using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiJuego
{
    internal class Kart
    {
        public float gravedad = 0.1f;
        public int a = 0;
        public float v = 1f;

        public float vy = 0;

        public float x = 0;

        public float y = 200f;


        public void Actualizar()
        {
            x += 0;
            y += gravedad;
            y -= vy;
            vy -= gravedad;

        }
        public void Draw()
        {
            //Pintar un sprite en la posición x, 200
            Raylib_cs.Raylib.DrawRectangle((int) x, (int) y, 50, 30, Raylib_cs.Color.Red);
        }

        public void Acelerar()
        {
            v++;
        }

        public void Saltar()
        {
            vy = 1;
        }
    }
}
