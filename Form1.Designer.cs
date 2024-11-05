namespace AutopistaenFuga
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CarroPrincipal = new System.Windows.Forms.PictureBox();
            this.carro2 = new System.Windows.Forms.PictureBox();
            this.carro3 = new System.Windows.Forms.PictureBox();
            this.carro1 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MovimientoPista = new System.Windows.Forms.Timer(this.components);
            this.LadoDerecho = new System.Windows.Forms.Timer(this.components);
            this.LadoIzquierdo = new System.Windows.Forms.Timer(this.components);
            this.CarroAmarillo = new System.Windows.Forms.Timer(this.components);
            this.CarroAzulFuerte = new System.Windows.Forms.Timer(this.components);
            this.CarroAzulBajo = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CarroPrincipal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Puntuaje: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(237, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Velocidad: 0";
            // 
            // CarroPrincipal
            // 
            this.CarroPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.CarroPrincipal.Image = global::AutopistaenFuga.Properties.Resources._9_removebg_preview;
            this.CarroPrincipal.Location = new System.Drawing.Point(140, 341);
            this.CarroPrincipal.Name = "CarroPrincipal";
            this.CarroPrincipal.Size = new System.Drawing.Size(43, 77);
            this.CarroPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CarroPrincipal.TabIndex = 13;
            this.CarroPrincipal.TabStop = false;
            // 
            // carro2
            // 
            this.carro2.BackColor = System.Drawing.Color.Transparent;
            this.carro2.Image = global::AutopistaenFuga.Properties.Resources._7_removebg_preview;
            this.carro2.Location = new System.Drawing.Point(141, 46);
            this.carro2.Name = "carro2";
            this.carro2.Size = new System.Drawing.Size(43, 77);
            this.carro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carro2.TabIndex = 12;
            this.carro2.TabStop = false;
            // 
            // carro3
            // 
            this.carro3.BackColor = System.Drawing.Color.Transparent;
            this.carro3.Image = global::AutopistaenFuga.Properties.Resources._8_removebg_preview;
            this.carro3.Location = new System.Drawing.Point(258, 217);
            this.carro3.Name = "carro3";
            this.carro3.Size = new System.Drawing.Size(43, 77);
            this.carro3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carro3.TabIndex = 11;
            this.carro3.TabStop = false;
            // 
            // carro1
            // 
            this.carro1.BackColor = System.Drawing.Color.Transparent;
            this.carro1.Image = global::AutopistaenFuga.Properties.Resources._1_removebg_preview;
            this.carro1.Location = new System.Drawing.Point(23, 217);
            this.carro1.Name = "carro1";
            this.carro1.Size = new System.Drawing.Size(43, 77);
            this.carro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.carro1.TabIndex = 10;
            this.carro1.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox7.Location = new System.Drawing.Point(212, 375);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(12, 100);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox8.Location = new System.Drawing.Point(102, 375);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(12, 100);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox5.Location = new System.Drawing.Point(212, 241);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(12, 100);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox6.Location = new System.Drawing.Point(102, 241);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(12, 100);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox3.Location = new System.Drawing.Point(212, 95);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(12, 100);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox4.Location = new System.Drawing.Point(102, 95);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(12, 100);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Location = new System.Drawing.Point(212, -35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(12, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(102, -35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(12, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MovimientoPista
            // 
            this.MovimientoPista.Enabled = true;
            this.MovimientoPista.Interval = 10;
            this.MovimientoPista.Tick += new System.EventHandler(this.MovimientoPista_Tick);
            // 
            // LadoDerecho
            // 
            this.LadoDerecho.Interval = 10;
            this.LadoDerecho.Tick += new System.EventHandler(this.LadoDerecho_Tick);
            // 
            // LadoIzquierdo
            // 
            this.LadoIzquierdo.Interval = 10;
            this.LadoIzquierdo.Tick += new System.EventHandler(this.LadoIzquierdo_Tick);
            // 
            // CarroAmarillo
            // 
            this.CarroAmarillo.Enabled = true;
            this.CarroAmarillo.Interval = 10;
            this.CarroAmarillo.Tick += new System.EventHandler(this.CarroAmarillo_Tick);
            // 
            // CarroAzulFuerte
            // 
            this.CarroAzulFuerte.Enabled = true;
            this.CarroAzulFuerte.Interval = 10;
            this.CarroAzulFuerte.Tick += new System.EventHandler(this.CarroAzulFuerte_Tick);
            // 
            // CarroAzulBajo
            // 
            this.CarroAzulBajo.Enabled = true;
            this.CarroAzulBajo.Interval = 10;
            this.CarroAzulBajo.Tick += new System.EventHandler(this.CarroAzulBajo_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Font = new System.Drawing.Font("Agency FB", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Firebrick;
            this.label3.Location = new System.Drawing.Point(83, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fin Del Juego";
            this.label3.Visible = false;
            // 
            // b1
            // 
            this.b1.BackColor = System.Drawing.Color.PeachPuff;
            this.b1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.b1.Location = new System.Drawing.Point(123, 241);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(78, 42);
            this.b1.TabIndex = 15;
            this.b1.Text = "Repetir";
            this.b1.UseVisualStyleBackColor = false;
            this.b1.Visible = false;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(334, 461);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CarroPrincipal);
            this.Controls.Add(this.carro2);
            this.Controls.Add(this.carro3);
            this.Controls.Add(this.carro1);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 500);
            this.MinimumSize = new System.Drawing.Size(350, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuga 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.CarroPrincipal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox carro1;
        private System.Windows.Forms.PictureBox carro3;
        private System.Windows.Forms.PictureBox carro2;
        private System.Windows.Forms.PictureBox CarroPrincipal;
        private System.Windows.Forms.Timer MovimientoPista;
        private System.Windows.Forms.Timer LadoDerecho;
        private System.Windows.Forms.Timer LadoIzquierdo;
        private System.Windows.Forms.Timer CarroAmarillo;
        private System.Windows.Forms.Timer CarroAzulFuerte;
        private System.Windows.Forms.Timer CarroAzulBajo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b1;
    }
}

