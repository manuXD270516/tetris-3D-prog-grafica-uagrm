using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SharpGL;
using System.Media;
using System.IO;
using tetris3Dv1.App_Utils;
using tetris3Dv1.tipos;
using tetris3Dv1.App_Model;

namespace tetris3Dv1.App_Views
{
    /// <summary>
    /// The main form class.
    /// </summary>
    public partial class ViewTetris : Form
    {

        public Dictionary<string, Sonido> sonidosJuego;

        public DirectoryInfo dirRootProject;

        public bool InMouseDown = false;
        public DateTime inicio = DateTime.Now;

        public int lastY = 0;
        public int lastX = 0;

        public int rotacionX = 0;
        public int rotacionY = 0;

        public int nroCamara = 1;

        public JuegoControlador juegoController;
        public Contenedor contenedor;
        public Camera cameraTetris;
        public ConfiguracionUsuario configUser;

        public OpenGL objOpengGL;

        public DateTime timeEndGame;
        public DateTime timeNow;

        DateTime d;
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewTetris"/> class.
        /// </summary

        public ViewTetris()
        {
            d = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 0, 0, 0);

            juegoController = new JuegoControlador();
            contenedor = new Contenedor();
            cameraTetris = new Camera(Tipo_Camara.TIPO_1);
            dirRootProject = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent.Parent;

            timeNow = DateTime.Now;
            timeEndGame = DateTime.Now;

            InitializeComponent();

            juegoController.setStart(true);
            
            // load sonidos
            

            // configruracion del panel 
            tableLayoutPanel1.BackColor = Color.Black;

            /*SoundPlayer sound = new SoundPlayer();
            // obtener la ruta actual de donde se encuentra el archivo .wav
            DirectoryInfo d = new DirectoryInfo(Directory.GetCurrentDirectory());
            d = d.Parent.Parent; // retroceder dos carpetas \bin\debug


            string ruta = d.FullName + "\\musica\\tetris_gameboy.wav";
            sound.SoundLocation = ruta;
            sound.PlayLooping();*/
        }

        internal void bundleData(ConfiguracionUsuario configUser)
        {
            this.configUser = new ConfiguracionUsuario(configUser);
            // settear los valores 
            asignarConfiguraciones();
            cargarSonidos();
            // load texturas
            cargarTexturas();
        }

        private void asignarConfiguraciones()
        {
            lblJugador.Text = configUser.nickName;
            lblDificultad.Text = configUser.dificultad;
            lblTiempo.Text= configUser.tiempo.ToString(); // timer para reduir 
            lblPuntos.Text = configUser.puntos.ToString();
            // add 
            timeEndGame = timeEndGame.AddSeconds(configUser.tiempo.Seconds);
            timeEndGame = timeEndGame.AddMinutes(configUser.tiempo.Minutes);
            timeEndGame = timeEndGame.AddHours(configUser.tiempo.Hours);

            d = d.AddSeconds(configUser.tiempo.Seconds);
            d = d.AddMinutes(configUser.tiempo.Minutes);
            d = d.AddHours(configUser.tiempo.Hours);


            /*timeEndGame = timeEndGame.Add(configUser.tiempo);*/
            timerJuego.Start();
        }

        private void cargarTexturas()
        {
            //throw new NotImplementedException();
        }

        private void cargarSonidos()
        {
            string directory = dirRootProject.FullName;

            sonidosJuego = new Dictionary<string, Sonido>();
            sonidosJuego.Add(UtilsApp.SONIDO_JUEGO_TETRIS, new Sonido(UtilsApp.SONIDO_JUEGO_TETRIS, $"{directory}\\musica\\tetris_gameboy.wav"));
            sonidosJuego.Add(UtilsApp.SONIDO_GAMEOVER_TETRIS, new Sonido(UtilsApp.SONIDO_GAMEOVER_TETRIS, $"{directory}\\musica\\game_over.wav"));
            sonidosJuego.Add(UtilsApp.SONIDO_FILA_COMPLETA, new Sonido(UtilsApp.SONIDO_FILA_COMPLETA, $"{directory}\\musica\\fila_completa.wav"));
            if (configUser.reprodSonidos)
            {
                sonidosJuego[UtilsApp.SONIDO_JUEGO_TETRIS].play();
            }
            //sonidos.Add("juego tetris", new Sonido("juego tetris", $"{dirRootProject}\\musica\\tetris_gameboy.wav");
        }


        /// <summary>
        /// Handles the OpenGLDraw event of the openGLControl control. (Metodo en ejecucion todo el tiempo)
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RenderEventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs e)
        {
            glDraw();
        }
        public void glDraw()
        {

            //  Get the OpenGL object.
            //OpenGL gl = openGLControl.OpenGL;
            objOpengGL = openGLControl.OpenGL;

            

            /*objOpengGL.DrawText(100, 100, 128.0f, 128.0f, 128.0f, "Arial", 24.0f, "Drawing maze");
            objOpengGL.DrawText(0, 0, 1f, 1f, 1f, "verdana", 20, "Paused");

            objOpengGL.DrawText3D("Arial", 30f, 0, 0, "Sasasasaa");*/

            //tableLayoutPanel1.SetRow(l1, 2);

           
            //  Clear the color and depth buffer.
            objOpengGL.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Load the identity matrix.
            objOpengGL.MatrixMode(OpenGL.GL_MODELVIEW);
            objOpengGL.LoadIdentity();
            
            objOpengGL.Rotate((float)rotacionX, 1.0f, 0.0f, 0.0f);
            objOpengGL.Rotate((float)rotacionY, 0.0f, 1.0f, 0.0f);

            //gl.Color(0.0f,0.0f,1.0f);
            contenedor.dibujar(objOpengGL);
            //gl.Translate(5, 5, 5);
            // gl.Rotate(rot, 0, 0);
            // gl.Translate(-5.5f, -4.5f, -5.5f);

            //rot += 90;
            //gl.Translate(0,0,zzz);
            // gl.Rotate(0, 0, 90);
            //   gl.Rotate(0, 90, 0); 

            //  ju.piezaPintado(gl);

            juegoController.pintarPiezaSiguiente(objOpengGL);

            juegoController.piezaPintado(objOpengGL);
            // control de tiempo para accion de movimiento de las piezas
            DateTime fin = DateTime.Now;
            TimeSpan span = fin - inicio; // tiempo transcurrido
            if (span.Seconds == configUser.velocidadFiguras) // tiempo parametrizable
            {
                inicio = DateTime.Now;
                bool termino;
                juegoController.avanzarVerificandoFilaCompleta(out termino);
                lblPuntos.Text = juegoController.puntos.ToString();
                if (termino)
                {
                    MessageBox.Show($"Juego terminado, su puntuacion es : {juegoController.puntos}");
                }
            }
            // metodo para pintar
            juegoController.pintarPiezaDelBoard(objOpengGL);
            // falta validar (PG)
            //label1.Text = "PUNTUACION \n " + ju.getPuntuacion();
            //juegoController.avanzar();
            // ju.piezaPintado(gl);

        }



        /// <summary>
        /// Handles the OpenGLInitialized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  TODO: Initialise OpenGL here.

            //  Get the OpenGL object.
            //OpenGL gl = openGLControl.OpenGL;
            objOpengGL = openGLControl.OpenGL;

            //  Set the clear color.
            objOpengGL.ClearColor(0, 0, 0, 0);

        }

        /// <summary>
        /// Handles the Resized event of the openGLControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  TODO: Set the projection matrix here.
            
            //  Get the OpenGL object.
            //OpenGL gl = openGLControl.OpenGL;
            objOpengGL = openGLControl.OpenGL;

            //  Set the projection matrix.
            objOpengGL.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            objOpengGL.LoadIdentity();
            
            //  Create a perspective transformation.
            objOpengGL.Perspective(75.0f, (double)Width / (double)Height, 0.1f, 50.0f);

            //  Use the 'look at' helper function to position and aim the camera.
            //gl.LookAt(0, 0, 15, -5, 15, -35, 0, 0, 1);
            //gl.LookAt(0, 0, -30, 0, 0, 0, 25, 25, 25);
            objOpengGL.LookAt(0, 0, 25, 0, 0, 0, 0, 1, 0);
            //gl.LookAt(4, 4, -7, 4, 4, 50, 0, 1, 0);

            //  Set the modelview matrix.
            objOpengGL.MatrixMode(OpenGL.GL_MODELVIEW);

        }

        /// <summary>
        /// The current rotation.
        /// </summary>


        private void SharpGLForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        

        private void movimientos(object sender, KeyPressEventArgs e)
        {
            //OpenGL gl = openGLControl.OpenGL;
            objOpengGL = openGLControl.OpenGL;
            switch (e.KeyChar)
            {
                case 'a':
                    juegoController.moverX(-1);
                    break;
                case 'd':
                    juegoController.moverX(1);
                    break;
                case 'w':
                    juegoController.moverY(-1);
                    break;
                case 's':
                    juegoController.moverY(1);
                    break;
                case '4':
                    juegoController.rotaciones(2);
                    break;
                case '6':
                    juegoController.rotaciones(1);
                    break;
                case '8':
                    juegoController.rotaciones(3);
                    break;
                case '2':
                    juegoController.rotaciones(4);
                    break;
                case '7':
                    juegoController.rotaciones(6);
                    break;
                case '9':
                    juegoController.rotaciones(5);
                    break;
                case ' ':
                    bool termino;
                    if (juegoController.avanzarVerificandoFilaCompleta(out termino))
                    {
                        lblPuntos.Text = juegoController.puntos.ToString();
                        sonidosJuego[UtilsApp.SONIDO_FILA_COMPLETA].play(repetead:false);
                    }
                    if (termino)
                    {
                        timerJuego.Stop();
                        MessageBox.Show($"Juego terminado, su puntuacion es : {juegoController.puntos}");
                        sonidosJuego[UtilsApp.SONIDO_GAMEOVER_TETRIS].play(repetead: false);
                    }
                    break;
                case 'r': // restart
                    juegoController = new JuegoControlador(); // habilitar un control UI para mostrar que el juego ha sido pausado/continua
                    juegoController.setStart(true);
                    break;
                case 'p': // pause
                    juegoController.setpause(true);
                    break;
                case 'c': // continue
                    juegoController.setpause(false);
                    break;
                case 't':
                    cameraTetris.nextCamera(Math.Abs((nroCamara++)) % UtilsApp.tiposCamaras.Length);
                    cameraTetris.enfocar(ref objOpengGL, Width, Height);
                    break;
            }
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            int x, y;
            if (e.Button == MouseButtons.Left && InMouseDown == true)
            {
                y = e.X;
                x = e.Y;
                rotacionX += (x - lastX) / 75;
                rotacionY += (y - lastY) / 75;
                glDraw();

            }
        }

        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastY = e.X;
                lastX = e.Y;
                //InMouseDown = true;
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openGLControl_Load(object sender, EventArgs e)
        {

        }


        // camara previa
        private void btnPrevCamera_Click(object sender, EventArgs e)
        {
            int value = Math.Abs((--nroCamara)) % UtilsApp.tiposCamaras.Length;
            cameraTetris.nextCamera(value);
            cameraTetris.enfocar(ref objOpengGL, Width, Height);
            
        }

        // camara next 
        private void btnNextCamera_Click(object sender, EventArgs e)
        {
            int value = Math.Abs((++nroCamara)) % UtilsApp.tiposCamaras.Length;
            cameraTetris.nextCamera(value);
            cameraTetris.enfocar(ref objOpengGL, Width, Height);
        }

        
        
        private void timerEndGame_Tick(object sender, EventArgs e)
        {
            timeEndGame=timeEndGame.AddSeconds(-1);
            d = d.AddSeconds(-1);
            //lblTiempo.Text = timeEndGame.ToString("hh:mm:ss");
            lblTiempo.Text = d.ToString("HH:mm:ss");
            if (timeEndGame.CompareTo(timeNow) == 0)
            {
                timerJuego.Stop();
                lblTiempo.Text = "00:00:00";
                string estadoJuego = configUser.puntos >= UtilsApp.PUNTUACION? "GANADOR":"PERDEDOR"; 
                string message = $"Juego Finalizado....!!!!, PUNTOS DEL USUARIO : {configUser.puntos} => {estadoJuego}";
                MessageBox.Show(message);
                if (MessageBox.Show(this,"Desea Reiniciar el juego...!!!", "TETRIS", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    juegoController = new JuegoControlador();
                    juegoController.setStart(true);
                }
            }
        }

        private void cbxHabilitarCamMov_CheckedChanged(object sender, EventArgs e)
        {
            InMouseDown = cbxHabilitarCamMov.Checked;
        }

        private void openGLControl_Load_1(object sender, EventArgs e)
        {

        }
    }
}
