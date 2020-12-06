namespace tetris3Dv1.App_Views
{
    partial class ViewTetris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTetris));
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblDificultad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblJugador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnNextCamera = new System.Windows.Forms.Button();
            this.btnPrevCamera = new System.Windows.Forms.Button();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cbxHabilitarCamMov = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.BackColor = System.Drawing.Color.Black;
            this.lblPuntos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPuntos.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntos.ForeColor = System.Drawing.Color.Yellow;
            this.lblPuntos.Location = new System.Drawing.Point(3, 259);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(285, 37);
            this.lblPuntos.TabIndex = 5;
            this.lblPuntos.Text = "0";
            this.lblPuntos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDificultad
            // 
            this.lblDificultad.AutoSize = true;
            this.lblDificultad.BackColor = System.Drawing.Color.Black;
            this.lblDificultad.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDificultad.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDificultad.ForeColor = System.Drawing.Color.Yellow;
            this.lblDificultad.Location = new System.Drawing.Point(3, 111);
            this.lblDificultad.Name = "lblDificultad";
            this.lblDificultad.Size = new System.Drawing.Size(285, 37);
            this.lblDificultad.TabIndex = 3;
            this.lblDificultad.Text = "FACIL";
            this.lblDificultad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "DIFICUTAD :";
            // 
            // lblJugador
            // 
            this.lblJugador.AutoSize = true;
            this.lblJugador.BackColor = System.Drawing.Color.Black;
            this.lblJugador.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblJugador.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugador.ForeColor = System.Drawing.Color.Yellow;
            this.lblJugador.Location = new System.Drawing.Point(3, 37);
            this.lblJugador.Name = "lblJugador";
            this.lblJugador.Size = new System.Drawing.Size(285, 37);
            this.lblJugador.TabIndex = 1;
            this.lblJugador.Text = "MANUEL";
            this.lblJugador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "JUGADOR :";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblJugador, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblDificultad, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblPuntos, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTiempo, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.cbxHabilitarCamMov, 0, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.04567F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.997313F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.98388F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(291, 744);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "PUNTOS :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 35);
            this.label8.TabIndex = 7;
            this.label8.Text = "TIEMPO :";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.BackColor = System.Drawing.Color.Black;
            this.lblTiempo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTiempo.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.ForeColor = System.Drawing.Color.Yellow;
            this.lblTiempo.Location = new System.Drawing.Point(3, 185);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(285, 37);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "00:00:00";
            this.lblTiempo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(285, 37);
            this.label7.TabIndex = 9;
            this.label7.Text = "CAMARA :";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnNextCamera, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPrevCamera, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 336);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(285, 105);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // btnNextCamera
            // 
            this.btnNextCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNextCamera.ForeColor = System.Drawing.Color.Transparent;
            this.btnNextCamera.Image = ((System.Drawing.Image)(resources.GetObject("btnNextCamera.Image")));
            this.btnNextCamera.Location = new System.Drawing.Point(145, 3);
            this.btnNextCamera.Name = "btnNextCamera";
            this.btnNextCamera.Size = new System.Drawing.Size(137, 99);
            this.btnNextCamera.TabIndex = 0;
            this.btnNextCamera.UseVisualStyleBackColor = true;
            this.btnNextCamera.Click += new System.EventHandler(this.btnNextCamera_Click);
            // 
            // btnPrevCamera
            // 
            this.btnPrevCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevCamera.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrevCamera.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevCamera.Image")));
            this.btnPrevCamera.Location = new System.Drawing.Point(3, 3);
            this.btnPrevCamera.Name = "btnPrevCamera";
            this.btnPrevCamera.Size = new System.Drawing.Size(136, 99);
            this.btnPrevCamera.TabIndex = 1;
            this.btnPrevCamera.UseVisualStyleBackColor = true;
            this.btnPrevCamera.Click += new System.EventHandler(this.btnPrevCamera_Click);
            // 
            // openGLControl
            // 
            this.openGLControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openGLControl.DrawFPS = true;
            this.openGLControl.Location = new System.Drawing.Point(0, 0);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(5);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.FBO;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(1433, 744);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load_1);
            this.openGLControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.movimientos);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            // 
            // timerJuego
            // 
            this.timerJuego.Tick += new System.EventHandler(this.timerEndGame_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 444);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "CAMARA MOVIBLE :";
            // 
            // cbxHabilitarCamMov
            // 
            this.cbxHabilitarCamMov.AutoSize = true;
            this.cbxHabilitarCamMov.BackColor = System.Drawing.Color.Black;
            this.cbxHabilitarCamMov.Font = new System.Drawing.Font("Tempus Sans ITC", 16.2F, System.Drawing.FontStyle.Bold);
            this.cbxHabilitarCamMov.ForeColor = System.Drawing.Color.Yellow;
            this.cbxHabilitarCamMov.Location = new System.Drawing.Point(3, 484);
            this.cbxHabilitarCamMov.Name = "cbxHabilitarCamMov";
            this.cbxHabilitarCamMov.Size = new System.Drawing.Size(197, 31);
            this.cbxHabilitarCamMov.TabIndex = 12;
            this.cbxHabilitarCamMov.Text = "HABILITAR ";
            this.cbxHabilitarCamMov.UseVisualStyleBackColor = false;
            this.cbxHabilitarCamMov.CheckedChanged += new System.EventHandler(this.cbxHabilitarCamMov_CheckedChanged);
            // 
            // ViewTetris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 744);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.openGLControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewTetris";
            this.Text = "TETRIS - Programacion Grafica";
            this.Load += new System.EventHandler(this.SharpGLForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblDificultad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblJugador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnNextCamera;
        private System.Windows.Forms.Button btnPrevCamera;
        private System.Windows.Forms.Timer timerJuego;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxHabilitarCamMov;
    }
}

