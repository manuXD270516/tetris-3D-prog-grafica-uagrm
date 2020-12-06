using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tetris3Dv1
{
    public class Cubo
    {
        int i;
        Punto3D posicion;
        double[,] colores;


        public Cubo()
        {
            // inicializa una matriz de colores
            initMatrixColors();
            i = 1;
            posicion = new Punto3D();
        }

        public void initMatrixColors()
        {
            colores = new double[6, 3] {    { -5.3, -5.0, 10 },
                                            { 0.3, 1.25, 0.0 },
                                            { 50.0, 0.0, 0.5 },
                                            { 0.1, 0.7, 20.0 },
                                            { 0.5, 0.0, 10.0 },
                                            { 10, 3.1, -1.25 }
                                        };
        }

        public void Setcolor(int p1)
        {
            i = p1;

        }

        public Cubo(Punto3D p1)
        {
            posicion = p1;
            initMatrixColors();
            //colores = new double[6, 3] { { -5.3, -5.0, 10 }, { 0.3, 1.25, 0.0 }, { 50, 0, 0.5 }, { 0.1, 0.7, 20 }, { 0.5, 0.0, 10 }, { 10, 3.1, -1.25 } };
            i = 0;
        }
        public void SetPosicion(Punto3D p1)
        {
            posicion = p1;

        }
        public Punto3D getPosicion()
        {
            return posicion;
        }
        public void drawCubo(OpenGL gl)
        {

            float x;
            float y;
            float z;

            x = posicion.getx();
            y = posicion.gety();
            z = posicion.getz();

            gl.Begin(OpenGL.GL_QUADS);
            int pos = (i - 1)< 0 ? 0 : i - 1; // validar los colores


            gl.Color(colores[pos, 0], colores[pos, 1], colores[pos , 2]);

            //arriba
            gl.Vertex(x, y, z);
            gl.Vertex(x + 1, y, z);
            gl.Vertex(x + 1, y, z + 1);
            gl.Vertex(x, y, z + 1);

            //abajo

            gl.Vertex(x, y + 1, z);
            gl.Vertex(x + 1, y + 1, z);
            gl.Vertex(x + 1, y + 1, z + 1);
            gl.Vertex(x, y + 1, z + 1);

            //lateralIzq

            gl.Vertex(x, y, z);
            gl.Vertex(x, y + 1, z);
            gl.Vertex(x, y + 1, z + 1);
            gl.Vertex(x, y, z + 1);


            //lateral abajo

            gl.Vertex(x, y, z + 1);
            gl.Vertex(x + 1, y, z + 1);
            gl.Vertex(x + 1, y + 1, z + 1);
            gl.Vertex(x, y + 1, z + 1);

            //lateral Arriba

            gl.Vertex(x, y, z);
            gl.Vertex(x + 1, y, z);
            gl.Vertex(x + 1, y + 1, z);
            gl.Vertex(x, y + 1, z);

            //lateralDer

            gl.Vertex(x + 1, y, z);
            gl.Vertex(x + 1, y + 1, z);
            gl.Vertex(x + 1, y + 1, z + 1);
            gl.Vertex(x + 1, y, z + 1);
            gl.End();


            // para generar lineas en cada parte del cubo
            /*gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(1f, 1f, 1f);
            gl.Vertex(x, y, z);
            gl.Vertex(x + 1, y, z);
            gl.Vertex(x + 1, y, z + 1);
            gl.Vertex(x, y, z + 1);

            gl.End();


            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(1f, 1f, 1f);
            gl.Vertex(x, y + 1, z);
            gl.Vertex(x + 1, y + 1, z);
            gl.Vertex(x + 1, y + 1, z + 1);
            gl.Vertex(x, y + 1, z + 1);
            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(1f, 1f, 1f);
            gl.Vertex(x, y, z);
            gl.Vertex(x, y + 1, z);
            gl.Vertex(x, y + 1, z + 1);
            gl.Vertex(x, y, z + 1);
            gl.End();


            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(1f, 1f, 1f);
            gl.Vertex(x, y, z + 1);
            gl.Vertex(x + 1, y, z + 1);
            gl.Vertex(x + 1, y + 1, z + 1);
            gl.Vertex(x, y + 1, z + 1);


            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);
            gl.Color(1f, 1f, 1f);
            gl.Vertex(x, y, z);
            gl.Vertex(x + 1, y, z);
            gl.Vertex(x + 1, y + 1, z);
            gl.Vertex(x, y + 1, z);

            gl.End();

            gl.Begin(OpenGL.GL_LINE_LOOP);

            gl.Color(1f, 1f, 1f);
            gl.Vertex(x + 1, y, z);
            gl.Vertex(x + 1, y + 1, z);
            gl.Vertex(x + 1, y + 1, z + 1);
            gl.Vertex(x + 1, y, z + 1);
            gl.End();*/





        }
    }


}
