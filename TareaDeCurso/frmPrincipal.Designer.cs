namespace pjContabilidadMetodosValuacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbMetodosSegmentacion = new System.Windows.Forms.GroupBox();
            this.rbEstadistico = new System.Windows.Forms.RadioButton();
            this.rbPuntoAltoBajo = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.gbMetodosValuacion = new System.Windows.Forms.GroupBox();
            this.rbIdentificacionEspecifica = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbUEPS = new System.Windows.Forms.RadioButton();
            this.rbPEPS = new System.Windows.Forms.RadioButton();
            this.rbPromedioPonderado = new System.Windows.Forms.RadioButton();
            this.rbPromedioSimple = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSiguiente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbMetodosSegmentacion.SuspendLayout();
            this.gbMetodosValuacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(273, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Métodos de Valuación y Segmentación";
            // 
            // gbMetodosSegmentacion
            // 
            this.gbMetodosSegmentacion.BackColor = System.Drawing.Color.Transparent;
            this.gbMetodosSegmentacion.Controls.Add(this.rbEstadistico);
            this.gbMetodosSegmentacion.Controls.Add(this.rbPuntoAltoBajo);
            this.gbMetodosSegmentacion.Controls.Add(this.label2);
            this.gbMetodosSegmentacion.Font = new System.Drawing.Font("Sitka Heading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbMetodosSegmentacion.Location = new System.Drawing.Point(31, 113);
            this.gbMetodosSegmentacion.Name = "gbMetodosSegmentacion";
            this.gbMetodosSegmentacion.Size = new System.Drawing.Size(375, 233);
            this.gbMetodosSegmentacion.TabIndex = 2;
            this.gbMetodosSegmentacion.TabStop = false;
            this.gbMetodosSegmentacion.Text = "Métodos de Segmentación";
            // 
            // rbEstadistico
            // 
            this.rbEstadistico.AutoSize = true;
            this.rbEstadistico.Location = new System.Drawing.Point(127, 96);
            this.rbEstadistico.Name = "rbEstadistico";
            this.rbEstadistico.Size = new System.Drawing.Size(106, 27);
            this.rbEstadistico.TabIndex = 2;
            this.rbEstadistico.Text = "Estadístico";
            this.rbEstadistico.UseVisualStyleBackColor = true;
            // 
            // rbPuntoAltoBajo
            // 
            this.rbPuntoAltoBajo.AutoSize = true;
            this.rbPuntoAltoBajo.Location = new System.Drawing.Point(125, 42);
            this.rbPuntoAltoBajo.Name = "rbPuntoAltoBajo";
            this.rbPuntoAltoBajo.Size = new System.Drawing.Size(186, 27);
            this.rbPuntoAltoBajo.TabIndex = 1;
            this.rbPuntoAltoBajo.Text = "Punto Alto, Punto Bajo";
            this.rbPuntoAltoBajo.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selecciona :";
            // 
            // gbMetodosValuacion
            // 
            this.gbMetodosValuacion.BackColor = System.Drawing.Color.Transparent;
            this.gbMetodosValuacion.Controls.Add(this.rbIdentificacionEspecifica);
            this.gbMetodosValuacion.Controls.Add(this.label4);
            this.gbMetodosValuacion.Controls.Add(this.rbUEPS);
            this.gbMetodosValuacion.Controls.Add(this.rbPEPS);
            this.gbMetodosValuacion.Controls.Add(this.rbPromedioPonderado);
            this.gbMetodosValuacion.Controls.Add(this.rbPromedioSimple);
            this.gbMetodosValuacion.Controls.Add(this.label3);
            this.gbMetodosValuacion.Font = new System.Drawing.Font("Sitka Heading", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.gbMetodosValuacion.Location = new System.Drawing.Point(547, 113);
            this.gbMetodosValuacion.Name = "gbMetodosValuacion";
            this.gbMetodosValuacion.Size = new System.Drawing.Size(447, 233);
            this.gbMetodosValuacion.TabIndex = 3;
            this.gbMetodosValuacion.TabStop = false;
            this.gbMetodosValuacion.Text = "Métodos de Valuación";
            // 
            // rbIdentificacionEspecifica
            // 
            this.rbIdentificacionEspecifica.AutoSize = true;
            this.rbIdentificacionEspecifica.Location = new System.Drawing.Point(126, 66);
            this.rbIdentificacionEspecifica.Name = "rbIdentificacionEspecifica";
            this.rbIdentificacionEspecifica.Size = new System.Drawing.Size(198, 27);
            this.rbIdentificacionEspecifica.TabIndex = 7;
            this.rbIdentificacionEspecifica.Text = "Identificación Específica";
            this.rbIdentificacionEspecifica.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sistema  Valuación Perpetuo";
            // 
            // rbUEPS
            // 
            this.rbUEPS.AutoSize = true;
            this.rbUEPS.Location = new System.Drawing.Point(127, 181);
            this.rbUEPS.Name = "rbUEPS";
            this.rbUEPS.Size = new System.Drawing.Size(67, 27);
            this.rbUEPS.TabIndex = 5;
            this.rbUEPS.Text = "UEPS";
            this.rbUEPS.UseVisualStyleBackColor = true;
            // 
            // rbPEPS
            // 
            this.rbPEPS.AutoSize = true;
            this.rbPEPS.Location = new System.Drawing.Point(127, 153);
            this.rbPEPS.Name = "rbPEPS";
            this.rbPEPS.Size = new System.Drawing.Size(65, 27);
            this.rbPEPS.TabIndex = 4;
            this.rbPEPS.Text = "PEPS";
            this.rbPEPS.UseVisualStyleBackColor = true;
            // 
            // rbPromedioPonderado
            // 
            this.rbPromedioPonderado.AutoSize = true;
            this.rbPromedioPonderado.Location = new System.Drawing.Point(126, 124);
            this.rbPromedioPonderado.Name = "rbPromedioPonderado";
            this.rbPromedioPonderado.Size = new System.Drawing.Size(214, 27);
            this.rbPromedioPonderado.TabIndex = 3;
            this.rbPromedioPonderado.Text = "Costo Promedio Ponderado";
            this.rbPromedioPonderado.UseVisualStyleBackColor = true;
            // 
            // rbPromedioSimple
            // 
            this.rbPromedioSimple.AutoSize = true;
            this.rbPromedioSimple.Location = new System.Drawing.Point(126, 96);
            this.rbPromedioSimple.Name = "rbPromedioSimple";
            this.rbPromedioSimple.Size = new System.Drawing.Size(188, 27);
            this.rbPromedioSimple.TabIndex = 2;
            this.rbPromedioSimple.Text = "Costo Promedio Simple";
            this.rbPromedioSimple.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Selecciona :";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.White;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.Image = global::pjContabilidadMetodosValuacion.Properties.Resources.next;
            this.btnSiguiente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiguiente.Location = new System.Drawing.Point(412, 373);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(128, 37);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "Next :D";
            this.btnSiguiente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1066, 589);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.gbMetodosValuacion);
            this.Controls.Add(this.gbMetodosSegmentacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbMetodosSegmentacion.ResumeLayout(false);
            this.gbMetodosSegmentacion.PerformLayout();
            this.gbMetodosValuacion.ResumeLayout(false);
            this.gbMetodosValuacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox gbMetodosSegmentacion;
        private RadioButton rbEstadistico;
        private RadioButton rbPuntoAltoBajo;
        private Label label2;
        private GroupBox gbMetodosValuacion;
        private Label label4;
        private RadioButton rbUEPS;
        private RadioButton rbPEPS;
        private RadioButton rbPromedioPonderado;
        private RadioButton rbPromedioSimple;
        private Label label3;
        private RadioButton rbIdentificacionEspecifica;
        private Button btnSiguiente;
    }
}