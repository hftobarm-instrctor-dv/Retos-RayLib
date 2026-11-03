using Kart;
using MiJuego;
using Raylib_cs;

namespace MiJuegoRaylib
{
    class Program
    {
        public static void Main()
        {
            // Inicializar la ventana
            const int screenWidth = 800;
            const int screenHeight = 450;

            Pelota p = new Pelota();


            Raylib.InitWindow(screenWidth, screenHeight, "raylib [core] con C# - Ventana de prueba");

            Raylib.SetTargetFPS(60); // Configurar a 60 FPS
            Flor miFLor = new Flor();
            Flor miSegundaFlor = new Flor(100, 0);
            //Game Loop (Ciclo de juego)
            while (!Raylib.WindowShouldClose())
            {
                // 1. Actualizar lógica de juego aquí
                // ----------------------------------------------------------------------------------
                //Leer el estado del teclado y si se presiona la tecla espacio hacer acelerar al kart
                p.Actualizar();
                miFLor.Actualizar();


                // 2. Dibujar elementos en pantalla
                // ----------------------------------------------------------------------------------
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RayWhite);

                p.Draw();
                miFLor.Draw();
                miSegundaFlor.Draw();



                //Raylib.DrawText("¡Felicidades! raylib con C# está funcionando", 140, 200, 20, Color.LightGray);

                Raylib.EndDrawing();
            }

            // Cerrar la ventana y liberar recursos
            Raylib.CloseWindow();
        }
    }
}
