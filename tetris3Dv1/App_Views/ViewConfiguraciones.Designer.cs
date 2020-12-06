namespace tetris3Dv1.App_Views
{
    partial class ViewConfiguraciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewConfiguraciones));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEmpezarJuego = new System.Windows.Forms.Button();
            this.ckbActivarSonidos = new System.Windows.Forms.CheckBox();
            this.txtDuracion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNickname = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(422, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONFIGURACIONES TETRIS";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnEmpezarJuego);
            this.groupBox1.Controls.Add(this.ckbActivarSonidos);
            this.groupBox1.Controls.Add(this.txtDuracion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbDificultad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNickname);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(302, 140);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 371);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Juego :";
            // 
            // btnEmpezarJuego
            // 
            this.btnEmpezarJuego.BackColor = System.Drawing.Color.MediumBlue;
            this.btnEmpezarJuego.Location = new System.Drawing.Point(283, 292);
            this.btnEmpezarJuego.Name = "btnEmpezarJuego";
            this.btnEmpezarJuego.Size = new System.Drawing.Size(369, 55);
            this.btnEmpezarJuego.TabIndex = 9;
            this.btnEmpezarJuego.Text = "EMPEZAR JUEGO";
            this.btnEmpezarJuego.UseVisualStyleBackColor = false;
            this.btnEmpezarJuego.Click += new System.EventHandler(this.btnEmpezarJuego_Click);
            // 
            // ckbActivarSonidos
            // 
            this.ckbActivarSonidos.AutoSize = true;
            this.ckbActivarSonidos.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbActivarSonidos.Location = new System.Drawing.Point(283, 235);
            this.ckbActivarSonidos.Name = "ckbActivarSonidos";
            this.ckbActivarSonidos.Size = new System.Drawing.Size(227, 39);
            this.ckbActivarSonidos.TabIndex = 8;
            this.ckbActivarSonidos.Text = "Activar Sonidos";
            this.ckbActivarSonidos.UseVisualStyleBackColor = true;
            this.ckbActivarSonidos.CheckedChanged += new System.EventHandler(this.ckbActivarSonidos_CheckedChanged);
            // 
            // txtDuracion
            // 
            this.txtDuracion.Location = new System.Drawing.Point(283, 174);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(369, 35);
            this.txtDuracion.TabIndex = 6;
            this.txtDuracion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(95, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "DURACION :";
            // 
            // cmbDuracion
            // 
            this.cmbDificultad.BackColor = System.Drawing.Color.White;
            this.cmbDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Items.AddRange(new object[] {
            "Basico",
            "Intermedio",
            "Avanzado"});
            this.cmbDificultad.Location = new System.Drawing.Point(283, 113);
            this.cmbDificultad.Name = "cmbDuracion";
            this.cmbDificultad.Size = new System.Drawing.Size(369, 33);
            this.cmbDificultad.TabIndex = 4;
            this.cmbDificultad.SelectedIndexChanged += new System.EventHandler(this.cmbDificultad_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(95, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "DIFICULTAD :";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(283, 57);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(369, 35);
            this.txtNickname.TabIndex = 2;
            this.txtNickname.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "NICK NAME :";
            // 
            // ViewConfiguraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1369, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewConfiguraciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewConfiguraciones";
            this.Load += new System.EventHandler(this.ViewConfiguraciones_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbDificultad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtNickname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmpezarJuego;
        private System.Windows.Forms.CheckBox ckbActivarSonidos;
        private System.Windows.Forms.RichTextBox txtDuracion;
        private System.Windows.Forms.Label label4;
    }
}