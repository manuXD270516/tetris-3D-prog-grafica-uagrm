using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tetris3Dv1.tipos;

namespace tetris3Dv1
{
    public class Tetromino
    {
        public int color;
        //float[] color;
        public int[,,] figura; // clase para almacenar la logica de las piezas

        public Punto3D pos;
        public int puntaje { get; set; }

        //public Tipo_Tetromino tipo { get; set; }
   
        public Tetromino(Tipo_Tetromino tipo=Tipo_Tetromino.CUBO)
        {
            color = 1;
            pos = new Punto3D(0, 0, 15);

            figura = new int[3, 3, 3];
            //this.tipo = tipo;
            
        }

        public int getColor() => color;


        //public float[] GetColor()
        //{
        //    return color;
        //}

        //// Three-dimensional array.
        //int[, ,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
        //                         { { 7, 8, 9 }, { 10, 11, 12 } } };
        //// The same array with dimensions specified.
        //int[, ,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, 
        //                               { { 7, 8, 9 }, { 10, 11, 12 } } };


        public void setEstructuraPieza(Tipo_Tetromino tipo)
        {
            switch (tipo)
            {
                case Tipo_Tetromino.CUBO:
                    setTetraCuadrado();
                    break;
                case Tipo_Tetromino.T:
                    setTetraTe();
                    break;
                case Tipo_Tetromino.I:
                    setTetraI();
                    break;
                case Tipo_Tetromino.Z:
                    setTetraZeta();
                    break;
                case Tipo_Tetromino.S:
                    setTetraEse();
                    break;
                case Tipo_Tetromino.L:
                    setTetraEle();
                    break;
            }
            color = (int)tipo - 1;
        }



        /*public void setTipoPieza(int elegida)
        {
            switch (elegida)
            {
                case 0:
                    setTetraCuadrado();
                    break;
                case 1:
                    setTetraTe();

                    break;
                case 2:
                    setTetraI();
                    
                    break;
                case 3:
                    setTetraZeta();
                    
                    break;
                case 4:
                    setTetraEse();
                    
                    break;
                case 5:
                    setTetraEle();
                    break;
            }
            color = elegida - 1;
        }*/

        public void setTetraCuadrado()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    figura[i, j, 1] = 1;
                }
            }
            puntaje = 5;
        }

        public void setTetraTe()
        {
            for (int i = 0; i < 3; i++)
            {
                figura[i, 1, 1] = 1;
            }
            figura[1, 0, 1] = 1;

            puntaje = 10;
        }

        public void setTetraI()
        {
            for (int i = 0; i < 3; i++)
            {
                figura[i, 1, 1] = 1;
            }

            puntaje = 8;
        }

        public void setTetraZeta()
        {

            figura[0, 1, 1] = 1;
            figura[1, 1, 1] = 1;
            figura[1, 0, 1] = 1;
            figura[2, 0, 1] = 1;

            puntaje = 6;
        }

        public void setTetraEse()
        {


            figura[0, 0, 1] = 1;
            figura[1, 0, 1] = 1;
            figura[1, 1, 1] = 1;
            figura[2, 1, 1] = 1;

            puntaje = 12;

        }
        public void setTetraEle()
        {
            figura[0, 1, 1] = 1;
            figura[1, 1, 1] = 1;
            figura[2, 1, 1] = 1;
            figura[2, 0, 1] = 1;

            puntaje = 10;
        }

        public void setPos(Punto3D Newpos) => pos = Newpos;
        public Punto3D getPos() => pos;
        
        public void rotarX()
        {
            for (int f = 0; f < 3; f++)
            {
                int[,] aux = gira_izqX(f);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        figura[f, i, j] = aux[i, j];
                    }
                }
            }

        }
        public void rotarXN()
        {
            for (int f = 0; f < 3; f++)
            {
                int[,] aux = gira_derX(f);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        figura[f, i, j] = aux[i, j];
                    }
                }
            }
        }
        public void rotarY()
        {
            for (int c = 0; c < 3; c++)
            {
                int[,] aux = gira_izqY(c);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        figura[i, c, j] = aux[i, j];
                    }
                }
            }


        }
        public void rotarYN()
        {
            for (int c = 0; c < 3; c++)
            {
                int[,] aux = gira_derY(c);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        figura[i, c, j] = aux[i, j];
                    }
                }
            }


        }
        public void rotarZ()
        {
            for (int z = 0; z < 3; z++)
            {
                int[,] aux = gira_izqZ(z);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        figura[i, j, z] = aux[i, j];
                    }
                }

            }
        }
        public void rotarZN()
        {
            for (int z = 0; z < 3; z++)
            {
                int[,] aux = gira_derZ(z);
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        figura[i, j, z] = aux[i, j];
                    }
                }
            }


        }
        public int[,] gira_izqX(int fila)
        {
            int[,] aux = new int[3, 3];
            int t = 0;
            for (int i = 3 - 1; i >= 0; --i)
            {
                for (int j = 0; j < 3; j++)
                {
                    aux[t, j] = figura[fila, j, i];
                }
                t++;
            }
            return aux;
        }

        public int[,] gira_derX(int fila)
        {
            int[,] aux = new int[3, 3];
            int t;
            for (int i = 0; i < 3; i++)
            {
                t = 0;
                for (int j = 3 - 1; j >= 0; --j)
                {
                    aux[i, t] = figura[fila, j, i];
                    t++;
                }
            }
            return aux;
        }

        public int[,] gira_izqY(int columna)
        {
            int[,] aux = new int[3, 3];
            int t = 0;
            for (int i = 3 - 1; i >= 0; --i)
            {
                for (int j = 0; j < 3; j++)
                {
                    aux[t, j] = figura[j, columna, i];
                }
                t++;
            }
            return aux;
        }

        public int[,] gira_derY(int columna)
        {
            int[,] aux = new int[3, 3];
            int t;
            for (int i = 0; i < 3; i++)
            {
                t = 0;
                for (int j = 3 - 1; j >= 0; --j)
                {
                    aux[i, t] = figura[j, columna, i];
                    t++;
                }
            }
            return aux;
        }

        public int[,] gira_izqZ(int zeta)
        {
            int[,] aux = new int[3, 3];
            int t = 0;
            for (int i = 3 - 1; i >= 0; --i)
            {
                for (int j = 0; j < 3; j++)
                {
                    aux[t, j] = figura[j, i, zeta];
                }
                t++;
            }
            return aux;
        }

        public int[,] gira_derZ(int zeta)
        {
            int[,] aux = new int[3, 3];
            int t;
            for (int i = 0; i < 3; i++)
            {
                t = 0;
                for (int j = 3 - 1; j >= 0; --j)
                {
                    aux[i, t] = figura[j, i, zeta];
                    t++;
                }
            }
            return aux;
        }
        public void clonar(Tetromino aux)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (aux.figura[i, j, k] != 0)
                        {
                            figura[i, j, k] = 1;
                        }
                    }
                }
            }
            color = aux.color;
            pos = aux.pos;
        }
    }
}
