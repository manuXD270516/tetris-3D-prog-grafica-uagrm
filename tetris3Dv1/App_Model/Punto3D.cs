using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tetris3Dv1
{
    public class Punto3D
    {
        float cx;
        float cy;
        float cz;
        public Punto3D()
        {
            cx = 0;
            cy = 0;
            cz = 0;
        }
        public Punto3D(float x, float y, float z)
        {
            cx = x;
            cy = y;
            cz = z;
        }


        public void setpunto(float x, float y, float z)
        {
            cx = x;
            cy = y;
            cz = z;
        }
        public Punto3D getpunto()
        {
            return this;
        }
        public void setx(float xnuevo)
        {
            cx = xnuevo;

        }
        public void sety(float ynuevo)
        {
            cy = ynuevo;

        }
        public void setz(float znuevo)
        {
            cz = znuevo;

        }
        public float getx()
        {
            return cx;
        }
        public float gety()
        {
            return cy;
        }
        public float getz()
        {
            return cz;
        }
    }
}
