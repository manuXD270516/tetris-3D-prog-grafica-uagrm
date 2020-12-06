using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using tetris3Dv1.App_Model;

namespace tetris3Dv1.App_Views
{
    public partial class ViewConfiguraciones : Form
    {
        public string[] tiempoGame;
        public bool sonido;

        public ViewConfiguraciones()
        {
            InitializeComponent();
            
        }

        private void ViewConfiguraciones_Load(object sender, EventArgs e)
        {
            tiempoGame = new string[]{ "00:30:00", "00:25:00", "00:20:00" };
            cmbDificultad.SelectedIndex = 0;
        }

        private void cmbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDuracion.Text = tiempoGame[cmbDificultad.SelectedIndex];
            
            
        }

        private void btnEmpezarJuego_Click(object sender, EventArgs e)
        {
            if (camposRequeridosValidos())
            {
                int[] time = getTiempo(txtDuracion.Text.Trim());
                ConfiguracionUsuario configUser = new ConfiguracionUsuario()
                {
                    nickName = txtNickname.Text.Trim(),
                    dificultad = cmbDificultad.GetItemText(cmbDificultad.SelectedItem),
                    tiempo = new TimeSpan(time[0],time[1],time[2]),
                    reprodSonidos = sonido,
                    velocidadFiguras = getVelocidad(cmbDificultad.SelectedIndex)
                };               
                ViewTetris tetrisForm = new ViewTetris();
                tetrisForm.bundleData(configUser);
                tetrisForm.Show();
                Hide();
            }
        }

        private int getVelocidad(int index)
        {
            int val=0;
            switch (index)
            {
                case 0: val = 3; break;
                case 1: val = 2; break;
                case 2: val = 1; break;
            }
            return val;
        }

        private int[] getTiempo(string value)
        {
            string[] valueTime = value.Split(':');
            int[] time = new int[3];
            int index = 0;
            foreach (var v in valueTime)
            {
                time[index++] = int.Parse(v);
            }
            return time;
        }

        private bool camposRequeridosValidos() => !string.IsNullOrEmpty(txtNickname.Text) && !string.IsNullOrEmpty(txtDuracion.Text);
        
        private void ckbActivarSonidos_CheckedChanged(object sender, EventArgs e)
        {
            sonido = ckbActivarSonidos.Checked;
        }
    }
}
