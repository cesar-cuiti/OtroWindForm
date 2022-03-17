namespace WindForm3
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.listElemento = new System.Windows.Forms.ListView();
            this.Fecha = new System.Windows.Forms.Label();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.ckbCasado = new System.Windows.Forms.CheckBox();
            this.ckbSoltero = new System.Windows.Forms.CheckBox();
            this.PerfilPersona = new System.Windows.Forms.Label();
            this.colorFav = new System.Windows.Forms.ComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnTrabaja = new System.Windows.Forms.RadioButton();
            this.btnNoTrabaja = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numeroFav = new System.Windows.Forms.NumericUpDown();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.lblNumFavorito = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(309, 82);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(74, 82);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(44, 13);
            this.LblNombre.TabIndex = 2;
            this.LblNombre.Text = "Nombre";
            // 
            // listElemento
            // 
            this.listElemento.BackColor = System.Drawing.SystemColors.Info;
            this.listElemento.HideSelection = false;
            this.listElemento.Location = new System.Drawing.Point(77, 341);
            this.listElemento.Name = "listElemento";
            this.listElemento.Size = new System.Drawing.Size(259, 97);
            this.listElemento.TabIndex = 3;
            this.listElemento.UseCompatibleStateImageBehavior = false;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Location = new System.Drawing.Point(74, 123);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(60, 13);
            this.Fecha.TabIndex = 4;
            this.Fecha.Text = "Fecha Nac";
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(177, 123);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNac.TabIndex = 5;
            // 
            // ckbCasado
            // 
            this.ckbCasado.AutoSize = true;
            this.ckbCasado.Location = new System.Drawing.Point(177, 168);
            this.ckbCasado.Name = "ckbCasado";
            this.ckbCasado.Size = new System.Drawing.Size(65, 17);
            this.ckbCasado.TabIndex = 6;
            this.ckbCasado.Text = "Casado ";
            this.ckbCasado.UseVisualStyleBackColor = true;
            // 
            // ckbSoltero
            // 
            this.ckbSoltero.AutoSize = true;
            this.ckbSoltero.Location = new System.Drawing.Point(287, 168);
            this.ckbSoltero.Name = "ckbSoltero";
            this.ckbSoltero.Size = new System.Drawing.Size(59, 17);
            this.ckbSoltero.TabIndex = 7;
            this.ckbSoltero.Text = "Soltero";
            this.ckbSoltero.UseVisualStyleBackColor = true;
            // 
            // PerfilPersona
            // 
            this.PerfilPersona.AutoSize = true;
            this.PerfilPersona.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerfilPersona.ForeColor = System.Drawing.SystemColors.Highlight;
            this.PerfilPersona.Location = new System.Drawing.Point(74, 33);
            this.PerfilPersona.Name = "PerfilPersona";
            this.PerfilPersona.Size = new System.Drawing.Size(133, 20);
            this.PerfilPersona.TabIndex = 8;
            this.PerfilPersona.Text = "Perfil Persona";
            // 
            // colorFav
            // 
            this.colorFav.FormattingEnabled = true;
            this.colorFav.Location = new System.Drawing.Point(177, 202);
            this.colorFav.Name = "colorFav";
            this.colorFav.Size = new System.Drawing.Size(121, 21);
            this.colorFav.TabIndex = 9;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(78, 205);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(72, 13);
            this.lblColor.TabIndex = 10;
            this.lblColor.Text = "Color Favorito";
            // 
            // btnTrabaja
            // 
            this.btnTrabaja.AutoSize = true;
            this.btnTrabaja.Location = new System.Drawing.Point(0, 19);
            this.btnTrabaja.Name = "btnTrabaja";
            this.btnTrabaja.Size = new System.Drawing.Size(61, 17);
            this.btnTrabaja.TabIndex = 11;
            this.btnTrabaja.TabStop = true;
            this.btnTrabaja.Text = "Trabaja";
            this.btnTrabaja.UseVisualStyleBackColor = true;
            // 
            // btnNoTrabaja
            // 
            this.btnNoTrabaja.AutoSize = true;
            this.btnNoTrabaja.Location = new System.Drawing.Point(124, 19);
            this.btnNoTrabaja.Name = "btnNoTrabaja";
            this.btnNoTrabaja.Size = new System.Drawing.Size(74, 17);
            this.btnNoTrabaja.TabIndex = 12;
            this.btnNoTrabaja.TabStop = true;
            this.btnNoTrabaja.Text = "No trabaja";
            this.btnNoTrabaja.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(241, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 13;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNoTrabaja);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.btnTrabaja);
            this.groupBox1.Location = new System.Drawing.Point(78, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 39);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // numeroFav
            // 
            this.numeroFav.Location = new System.Drawing.Point(177, 243);
            this.numeroFav.Name = "numeroFav";
            this.numeroFav.Size = new System.Drawing.Size(120, 20);
            this.numeroFav.TabIndex = 15;
            // 
            // btnPerfil
            // 
            this.btnPerfil.Location = new System.Drawing.Point(537, 398);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnPerfil.TabIndex = 16;
            this.btnPerfil.Text = "Ver Perfil";
            this.btnPerfil.UseVisualStyleBackColor = true;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // lblNumFavorito
            // 
            this.lblNumFavorito.AutoSize = true;
            this.lblNumFavorito.Location = new System.Drawing.Point(81, 243);
            this.lblNumFavorito.Name = "lblNumFavorito";
            this.lblNumFavorito.Size = new System.Drawing.Size(82, 13);
            this.lblNumFavorito.TabIndex = 17;
            this.lblNumFavorito.Text = "Numero favorito";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumFavorito);
            this.Controls.Add(this.btnPerfil);
            this.Controls.Add(this.numeroFav);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.colorFav);
            this.Controls.Add(this.PerfilPersona);
            this.Controls.Add(this.ckbSoltero);
            this.Controls.Add(this.ckbCasado);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.listElemento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.ListView listElemento;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.CheckBox ckbCasado;
        private System.Windows.Forms.CheckBox ckbSoltero;
        private System.Windows.Forms.Label PerfilPersona;
        private System.Windows.Forms.ComboBox colorFav;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.RadioButton btnTrabaja;
        private System.Windows.Forms.RadioButton btnNoTrabaja;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numeroFav;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Label lblNumFavorito;
    }
}

