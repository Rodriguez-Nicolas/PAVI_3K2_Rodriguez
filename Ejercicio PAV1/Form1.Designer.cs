namespace Ejercicio_PAV1
{
    partial class frmIniciarSesion
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
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.pbIniciarSesion = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciarSesion)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(235, 18);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(100, 20);
            this.tbUsuario.TabIndex = 0;
            this.tbUsuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(235, 64);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 1;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(260, 118);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 2;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(164, 118);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(161, 21);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(43, 13);
            this.lbUsuario.TabIndex = 4;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(161, 67);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(61, 13);
            this.lbContraseña.TabIndex = 5;
            this.lbContraseña.Text = "Contraseña";
            // 
            // pbIniciarSesion
            // 
            this.pbIniciarSesion.Image = global::Ejercicio_PAV1.Properties.Resources.iniciar_sesion;
            this.pbIniciarSesion.Location = new System.Drawing.Point(12, 18);
            this.pbIniciarSesion.Name = "pbIniciarSesion";
            this.pbIniciarSesion.Size = new System.Drawing.Size(134, 120);
            this.pbIniciarSesion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIniciarSesion.TabIndex = 6;
            this.pbIniciarSesion.TabStop = false;
            this.pbIniciarSesion.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 155);
            this.Controls.Add(this.pbIniciarSesion);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.tbContraseña);
            this.Controls.Add(this.tbUsuario);
            this.Name = "frmIniciarSesion";
            this.Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.pbIniciarSesion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.PictureBox pbIniciarSesion;
    }
}

