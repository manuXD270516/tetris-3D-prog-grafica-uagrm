using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tetris3Dv1.App_Utils;
using tetris3Dv1.tipos;

namespace tetris3Dv1
{
    public class Camera
    {
        public double eyeX { get; set; }
        public double eyeY { get; set; }
        public double eyeZ { get; set; }

        public double centerX { get; set; }
        public double centerY { get; set; }
        public double centerZ { get; set; }

        public double upX { get; set; }
        public double upY { get; set; }
        public double upZ { get; set; }

        public Tipo_Camara tipo { get; set; }

        public Camera(Tipo_Camara tipo) : this(0, 0, 0, 0, 0, 0, 0, 0, 0, tipo)
        {
        }
        
        public Camera(double eyeX, double eyeY, double eyeZ, double centerX, double centerY,double centerZ, double upX, double upY, double upZ, Tipo_Camara tipo=Tipo_Camara.TIPO_1)
        {
            this.eyeX = eyeX;
            this.eyeY = eyeY;
            this.eyeZ = eyeZ;

            this.centerX = centerX;
            this.centerY = centerY;
            this.centerZ = centerZ;

            this.upX = upX;
            this.upY = upY;
            this.upZ = upZ;

            this.tipo = tipo;
        }

        public void nextCamera(int pos) => tipo = (Tipo_Camara)UtilsApp.tiposCamaras.GetValue(pos);
        
        public void enfocar(ref OpenGL gl, double width, double height)
        {
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(60.0f, width / height, 0.1f, 50.0f);
            switch (tipo)
            {
                case Tipo_Camara.TIPO_1:
                    gl.LookAt(4, -8, -6, 4, 3, 3, 0, 1, 0);
                    //gl.LookAt(0, 0, 25, 0, 0, 0, 1, 0, 0);
                    break;
                case Tipo_Camara.TIPO_2:
                    gl.LookAt(4, 5, -9, 4, 4, 0, 0, 1, 0);
                    //gl.LookAt(0, 0, 25, 0, 0, 0, 1, 1, 0);
                    break;
                case Tipo_Camara.TIPO_3:
                    gl.LookAt(-7, 14, -5, 0, 8, 1, 0, 1, 0);
                    //gl.LookAt(0, 0, 25, 0, 0, 0, 1, 1, 1);
                    break;
                case Tipo_Camara.TIPO_4:
                    gl.LookAt(12, 12, -4, 4, 4, 3, 0, 1, 0);
                    //gl.LookAt(0, 0, 25, 0, 0, 0, 0, 1, 1);
                    break;
                case Tipo_Camara.TIPO_5:
                    gl.LookAt(12, 12, -4, 4, 4, 3, 0, 1, 0);
                    //gl.LookAt(0, 0, 25, 0, 0, 0, 0, 0, 0);
                    break;
                case Tipo_Camara.TIPO_6:
                    gl.LookAt(10, 12, -4, 4, 4, 3, 0, 1, 0);
                    break;
                case Tipo_Camara.TIPO_7:
                    gl.LookAt(0, 0, 25, 0, 0, 0, 0, 1, 0);
                    break;
                default:
                    break;
            }
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

    }
}
