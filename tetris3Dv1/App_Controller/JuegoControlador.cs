using ShadowEngine.Sound;
using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using tetris3Dv1.tipos;

namespace tetris3Dv1
{

    public class JuegoControlador
    {
        public int puntuacion;
        public int[,,] board;
        public bool inicio { get; set; }
        public bool pause { get; set; }
        public Tetromino tetrominoCurrent { get; set; }
        public Tetromino tetrominoNext { get; set; }

        public Tipo_Tetromino tipoTeraAct;

        public int puntos { get; set; }

        public JuegoControlador()
        {
            pause = false;
            puntuacion = 0;
            tetrominoCurrent = new Tetromino();
            tetrominoNext = new Tetromino();
            inicio = false;
            board = new int[8, 8, 15];
            tetrominoCurrent = nextTetromino();
            tetrominoNext = nextTetromino();

            //cantLineasEliminadas = 0;
        }

        //escoge una ficha 
        public Tetromino nextTetromino()
        {
            Tetromino tetrominoCurrent = new Tetromino();
            // generar figura randomica
            //Tipo_Tetromino tipoTetro = nextTetro();
            Tipo_Tetromino tipoTetro = Tipo_Tetromino.CUBO;
            //tetrominoCurrent.tipo = tipoTetro;
            tetrominoCurrent.setEstructuraPieza(tipoTetro);
            //Tipo_Tetromino tipoTetro = (Tipo_Tetromino)r.Next(0, 6);

            //Tipo_Tetromino tipoTetro = Tipo_Tetromino.CUBO;
            //int nroTetro = r.Next(0, 6);
            //tetrominoCurrent.setTipoPieza(tipoTetro);
            return tetrominoCurrent;
        }

        public Tipo_Tetromino nextTetro()
        {
            Random r = new Random();
            return (Tipo_Tetromino)(r.Next(0, 6));
        }

        public void setStart(bool b)
        {
            inicio = b;
        }
        public void setpause(bool b)
        {
            pause = b;
        }

        // realiza la accion de avanzar el tetromino actual
        public bool avanzarVerificandoFilaCompleta(out bool termino)
        {
            bool filaCompleta = false;
            termino = false;

            float x = tetrominoCurrent.getPos().getx();
            float y = tetrominoCurrent.getPos().gety();
            float z = tetrominoCurrent.getPos().getz();

            if (inicio && !pause)
            {
                bool v = validarAvanzar();
                if (z - 1 >= 0 && v) // validacion de avance
                {
                    tetrominoCurrent.setPos(new Punto3D(x, y, z - 1));
                }
                else
                {
                    puntos += añadir(out termino);
                    filaCompleta = eliminarFila();
                    if (filaCompleta)
                    {
                        MessageBox.Show("Linea eliminada, gano 50 puntos extas!!!","TETRIS");
                        puntos += 50; // eliminar un
                    }
                    tetrominoCurrent = tetrominoNext;
                    tetrominoNext = nextTetromino(); // obtiene nuevo tetromino
                }
            }
            return filaCompleta;
            /*if (filaCompleta && añadirFicha != 0)
            {
                return true;
            } else
            {
                return false;
            }*/

        }

        // valida si puede avanzar el tetromino actual
        public bool validarAvanzar()//avanzar  para abajo
        {
            bool b = false;
            float z1;
            float z0 = tetrominoCurrent.getPos().getz() - 1;
            float x0;
            float y0;
            if (z0 < 0)
            {
                z0 = 0;
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        if (tetrominoCurrent.figura[i, j, k] != 0)
                        {
                            x0 = j - 1;
                            y0 = i;
                            z1 = k - 1;
                            if (x0 == 1)
                            {
                                x0 = -1;
                            }
                            else
                            {
                                if (x0 < 0)
                                    x0 = 1;
                            }


                            if (z1 < 0)
                            {
                                z1 = -1;
                            }
                            x0 = x0 + tetrominoCurrent.getPos().getx();
                            y0 = y0 + tetrominoCurrent.getPos().gety();
                            z1 = z1 + z0;

                            if (x0 < 0 || y0 < 0 || z1 < 0)
                            {
                                return false;
                            }

                            if (board[(int)x0, (int)y0, (int)z1] == 0)
                                b = true;
                            else
                                return false;
                        }
                    }

            return b;

        }

        // añade una nueva figura al tablero
        public int añadir(out bool terminoJuego)
        {
            
            float x = tetrominoCurrent.getPos().getx();
            float y = tetrominoCurrent.getPos().gety();
            float z = tetrominoCurrent.getPos().getz();
            if (z < 0 || z == 15) // validacion de llegar al tope
            {
                
                inicio = false; terminoJuego = true;
                return 0;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (tetrominoCurrent.figura[i, j, k] != 0)
                        {

                            float x0 = j - 1;
                            float y0 = i;
                            float z1 = k - 1;
                            if (x0 == 1)
                            {
                                x0 = -1;
                            }
                            else
                            {
                                if (x0 < 0)
                                    x0 = 1;
                            }
                            if (z1 < 0)
                            {
                                z1 = -1;
                            }
                            x0 = x0 + x;
                            y0 = y0 + y;
                            z1 = z1 + z;
                            board[(int)x0, (int)y0, (int)z1] = tetrominoCurrent.getColor();
                        }
                        //   verificarFila();  
                    }
                }
            }
            terminoJuego = false;
            return tetrominoCurrent.puntaje;

        }

        public void pintarPiezaSiguiente(OpenGL gl)
        {
            float x = tetrominoNext.getPos().getx();
            float y = tetrominoNext.getPos().gety();
            float z = tetrominoNext.getPos().getz();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (tetrominoNext.figura[i, j, k] == 1)
                        {
                            float x0 = j - 1;
                            float y0 = i;
                            float z1 = k - 1;
                            if (x0 < 0)
                            {
                                x0 = -1;
                            }
                            if (z1 < 0)
                            {
                                z1 = -1;
                            }
                            x0 = x0 - x;
                            y0 = y0 + y;
                            z1 = z1 + z;

                            Cubo piezaCubo = new Cubo(new Punto3D(y0 + 4.5f, x0 + 3.5f, z1));
                            piezaCubo.Setcolor(tetrominoNext.getColor());
                            piezaCubo.drawCubo(gl);

                            gl.Begin(OpenGL.GL_LINE_LOOP);
                            gl.Color(1f, 1f, 1f);
                            gl.Vertex(4, 5.5, 15);
                            gl.Vertex(8.5, 5.5, 15);
                            gl.Vertex(8.5, 2, 15);
                            gl.Vertex(4, 2, 15);


                            gl.End();

                        }
                    }
                }
            }
        }
        public void piezaPintado(OpenGL gl)
        {

            float x = tetrominoCurrent.getPos().getx();
            float y = tetrominoCurrent.getPos().gety();
            float z = tetrominoCurrent.getPos().getz();

            if (z == 15)
            {
                return;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (tetrominoCurrent.figura[i, j, k] == 1)
                        {
                            float x0 = j - 1;
                            float y0 = i;
                            float z1 = k - 1;
                            if (x0 < 0)
                            {
                                x0 = -1;
                            }
                            if (z1 < 0)
                            {
                                z1 = -1;
                            }
                            x0 = x0 - x;
                            y0 = y0 + y;
                            z1 = z1 + z;

                            Cubo cub = new Cubo(new Punto3D(y0 - 4, x0 + 3, z1));
                            cub.Setcolor(tetrominoCurrent.getColor());
                            cub.drawCubo(gl);
                        }
                    }
                }
            }
        }



        public void pintarPiezaDelBoard(OpenGL gl)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 15; k++)
                    {
                        if (board[i, j, k] != 0)
                        {
                            Cubo cub = new Cubo(new Punto3D(j - 4, -i + 3, k));
                            cub.Setcolor(board[i, j, k]);
                            cub.drawCubo(gl);
                        }
                    }
                }
            }

        }
        public void moverX(int lado)
        {
            if (pause)
            {
                return;
            }
            if (tetrominoCurrent.getPos().gety() + lado > 7 || tetrominoCurrent.getPos().gety() + lado < 0 - 1 || tetrominoCurrent.getPos().getz() == 15)
            {
                return;
            }

            float x = tetrominoCurrent.getPos().getx();
            float y = tetrominoCurrent.getPos().gety();
            float z = tetrominoCurrent.getPos().getz();
            tetrominoCurrent.setPos(new Punto3D(x, y + lado, z));
            Boolean b = validarAvanzeX();
            if (!b)
            {
                tetrominoCurrent.setPos(new Punto3D(x, y, z));
            }
        }
        public bool validarAvanzeX()//avanzar  para los lados
        {
            bool b = false;

            float x0;
            float y0;
            float z1;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        if (tetrominoCurrent.figura[i, j, k] != 0)
                        {

                            x0 = j - 1;
                            y0 = i;
                            z1 = k - 1;
                            if (x0 == 1)
                            {
                                x0 = -1;
                            }
                            else
                            {
                                if (x0 < 0)
                                    x0 = 1;
                            }


                            if (z1 < 0)
                            {
                                z1 = -1;
                            }
                            x0 = x0 + tetrominoCurrent.getPos().getx();
                            y0 = y0 + tetrominoCurrent.getPos().gety();
                            z1 = z1 + tetrominoCurrent.getPos().getz();

                            if (y0 > 7 || y0 < 0)
                            {
                                return false;
                            }
                            if (board[(int)x0, (int)y0, (int)z1] == 0)
                                b = true;
                            else
                                return false;
                        }
                    }
            return b;

        }

        public bool validarAvanceY()
        {

            Boolean b = false;

            float x0;
            float y0;
            float z1;

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        if (tetrominoCurrent.figura[i, j, k] != 0)
                        {
                            x0 = j - 1;
                            y0 = i;
                            z1 = k - 1;
                            if (x0 == 1)
                            {
                                x0 = -1;
                            }
                            else
                            {
                                if (x0 < 0)
                                    x0 = 1;
                            }


                            if (z1 < 0)
                            {
                                z1 = -1;
                            }
                            x0 = x0 + tetrominoCurrent.getPos().getx();
                            y0 = y0 + tetrominoCurrent.getPos().gety();
                            z1 = z1 + tetrominoCurrent.getPos().getz(); ;

                            if (x0 > 7 || x0 < 0)
                            {
                                return false;
                            }
                            if (board[(int)x0, (int)y0, (int)z1] == 0)
                                b = true;
                            else
                                return false;
                        }
                    }
            return b;
        }
        public void moverY(int lado)
        {
            if (pause)
            {
                return;
            }
            if (tetrominoCurrent.getPos().getx() + lado < 0 || tetrominoCurrent.getPos().getx() + lado > 7 || tetrominoCurrent.getPos().getz() == 15)
            {
                return;
            }

            float x = tetrominoCurrent.getPos().getx();
            float y = tetrominoCurrent.getPos().gety();
            float z = tetrominoCurrent.getPos().getz();
            tetrominoCurrent.setPos(new Punto3D(x + lado, y, z));
            Boolean b = validarAvanceY();
            if (!b)
            {
                tetrominoCurrent.setPos(new Punto3D(x, y, z));
            }
        }
        public bool eliminarFila()
        {
            bool b = false;
            for (int i = 0; i < 15; i++)
            {
                if (b == true)
                {

                    borrarFila(i - 1);
                    // reproducir un sonido en caso de que se elimine una fila y aumentar la puntuacion
                    puntuacion += 100;
                    return true;
                }
                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                        if (board[j, k, i] != 0)
                        {
                            b = true;
                        }
                        else
                        {
                            b = false;
                            k = 9;
                            j = 9;
                        }
                }
            }
            return false;
        }
        public int getPuntuacion()
        {
            return puntuacion;
        }
        public void borrarFila(int z)
        {

            for (int i = z + 1; i < 15; i++)
            {

                for (int j = 0; j < 8; j++)
                {
                    for (int k = 0; k < 8; k++)
                    {
                        board[j, k, i - 1] = board[j, k, i];
                    }
                }
            }


            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j, 14] = 0;
                }

            }

        }
        public void rotaciones(int n)
        {
            if (pause)
            {
                return;
            }
            Tetromino aux = new Tetromino();
            aux.clonar(tetrominoCurrent);
            switch (n)
            {

                case 1:

                    aux.rotarX();
                    if (verifRotacion(aux))
                        tetrominoCurrent.rotarX();
                    break;
                case 2:
                    aux.rotarXN();
                    if (verifRotacion(aux))
                        tetrominoCurrent.rotarXN();
                    break;
                case 3:
                    aux.rotarY();
                    if (verifRotacion(aux))
                        tetrominoCurrent.rotarY();
                    break;
                case 4:
                    aux.rotarYN();
                    if (verifRotacion(aux))
                        tetrominoCurrent.rotarYN();
                    break;
                case 5:
                    aux.rotarZ();
                    if (verifRotacion(aux))
                        tetrominoCurrent.rotarZ();
                    break;
                case 6:
                    aux.rotarZN();
                    if (verifRotacion(aux))
                        tetrominoCurrent.rotarZN();
                    break;
            }
        }
        public bool verifRotacion(Tetromino aux)
        {
            bool b = false;
            float z1;
            float z0 = aux.getPos().getz();
            float x0;
            float y0;
            if (z0 < 0)
            {
                z0 = 0;
            }

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    for (int k = 0; k < 3; k++)
                    {
                        if (aux.figura[i, j, k] != 0)
                        {
                            x0 = j - 1;
                            y0 = i;
                            z1 = k - 1;
                            if (x0 == 1)
                            {
                                x0 = -1;
                            }
                            else
                            {
                                if (x0 < 0)
                                    x0 = 1;
                            }
                            if (z1 < 0)
                            {
                                z1 = -1;
                            }

                            x0 = x0 + aux.getPos().getx();
                            y0 = y0 + aux.getPos().gety();
                            z1 = z1 + z0;
                            if (x0 < 0 || y0 < 0 || z1 < 0 || z1 >= 15 || x0 > 7 || y0 > 7)
                            {
                                return false;
                            }
                            if (board[(int)x0, (int)y0, (int)z1] == 0)
                                b = true;
                            else
                                return false;
                        }
                    }

            return b;
        }
    }
}