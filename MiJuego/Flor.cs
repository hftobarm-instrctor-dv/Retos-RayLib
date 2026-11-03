using Raylib_cs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kart
{
    internal class Flor
    {

        private int x = 0;
        private int y = 0;

        public Flor()
        {
            x = 0;
            y = 0;
        }

        public Flor(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Actualizar()
        {
            const int velocidad = 2;

            if (Raylib.IsKeyDown(KeyboardKey.Up))
                y -= velocidad;

            if (Raylib.IsKeyDown(KeyboardKey.Down))
                y += velocidad;

            if (Raylib.IsKeyDown(KeyboardKey.Left))
                x -= velocidad;

            if (Raylib.IsKeyDown(KeyboardKey.Right))
                x += velocidad;
        }

        public void Draw()
        {
            int offsetX = x;
            int offsetY = y;

            // Dibujar el tallo
            Raylib.DrawRectangle(396 + offsetX, 250 + offsetY, 8, 130, Color.Green);

            // Dibujar las hojas
            Raylib.DrawCircle(380 + offsetX, 320 + offsetY, 25, Color.Green);
            Raylib.DrawCircle(420 + offsetX, 345 + offsetY, 25, Color.Green);

            // Dibujar los pétalos
            Raylib.DrawCircle(400 + offsetX, 200 + offsetY, 45, Color.Pink);
            Raylib.DrawCircle(350 + offsetX, 230 + offsetY, 45, Color.Pink);
            Raylib.DrawCircle(450 + offsetX, 230 + offsetY, 45, Color.Pink);
            Raylib.DrawCircle(370 + offsetX, 175 + offsetY, 45, Color.Pink);
            Raylib.DrawCircle(430 + offsetX, 175 + offsetY, 45, Color.Pink);
          

            // Dibujar el centro de la flor
            Raylib.DrawCircle(400 + offsetX, 215 + offsetY, 35, Color.Gold);
        }
    }
}
