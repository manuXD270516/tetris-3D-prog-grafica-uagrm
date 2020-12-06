using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace tetris3Dv1
{
    public class Contenedor
    {

        public void dibujar(OpenGL gl)
        {
            //gl.Color(24.0f, 1.0f, 1.0f);
            gl.Color(24.0f, 0.0f, 1.0f);
            gl.Begin(OpenGL.GL_LINES);

            // 16 lineas

            float Z = 0;
            for (int i = 0; i < 16; i++)
            {
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, 4.0, Z);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, -4.0, Z);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, -4.0, Z);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, -4.0, Z);
                Z = Z + 1;
            }
            Z = 0;


            for (int i = 0; i < 16; i++)
            {
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, -4.0, Z);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, 4.0, Z);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, 4.0, Z);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, 4.0, Z);

                Z = Z + 1f;

            }


            float X = 0;
            for (int i = 0; i < 9; i++)
            {
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0 + X, -4.0, 15);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0 + X, -4.0, 0);

                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0 + X, 4.0, 15);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0 + X, 4.0, 0);


                X = X + 1f;
            }
            X = 0;


            for (int i = 0; i < 9; i++)
            {
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, -4.0 + X, 15);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, -4.0 + X, 0);

                //IZQ
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, 4.0 - X, 15);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, 4.0 - X, 0);


                X = X + 1f;
            }


            X = 0;

            for (int i = 0; i < 9; i++)
            {
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(-4.0, 4 - X, 0);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0, 4 - X, 0);

                //IZQ
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0 - X, 4.0, 0);
                //gl.Color(1.0, 1.0, 0.0);
                gl.Vertex(4.0 - X, -4.0, 0);


                X = X + 1f;
            }

            gl.End();

        }
    }
}
