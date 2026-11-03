using Raylib_cs;

using System.Numerics;

namespace RotatedEllipse
{
    class Program
    {
        static void Main()
        {
            // Inicializar la ventana
            const int screenWidth = 800;
            const int screenHeight = 450;
            Raylib.InitWindow(screenWidth, screenHeight, "Raylib C# - Elipse Rotada");
            Raylib.SetTargetFPS(60);

            // Propiedades de la elipse
            Vector2 centro = new Vector2(screenWidth / 2, screenHeight / 2);
            float radioX = 150.0f;
            float radioY = 60.0f;
            float angulo = 0.0f; // Ángulo en grados

            while (!Raylib.WindowShouldClose())
            {
                // Actualizar: rotar la elipse continuamente con el tiempo
                angulo += 1.0f;

                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.RayWhite);

                Raylib.DrawText("Rotando una elipse usando matrices en raylib-cs", 10, 10, 20, Color.DarkGray);

                // --- INICIO DE LA ROTACIÓN ---
                // 1. Guardar la matriz de transformación actual
                Rlgl.PushMatrix();

                // 2. Mover el origen de coordenadas al centro de la elipse
                Rlgl.Translatef(centro.X, centro.Y, -100f);

                // 3. Rotar el sistema de coordenadas (el ángulo debe estar en grados)
                Rlgl.Rotatef(angulo, 0.0f, 0.0f, 1.0f);

                // 4. Dibujar la elipse en el nuevo origen (0, 0)
                Raylib.DrawEllipse(0, 0, radioX, radioY, Color.Maroon);

                // Opcional: Dibujar una línea interna para notar mejor la rotación
                Raylib.DrawLine(0, 0, (int)radioX, 0, Color.Gold);

                // 5. Restaurar la matriz original para no afectar a otros dibujos
                Rlgl.PopMatrix();
                // --- FIN DE LA ROTACIÓN ---

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}
