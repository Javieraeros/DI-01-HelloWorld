namespace HelloWorldWindowsFormsVB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.boton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texto = new System.Windows.Forms.TextBox();
            this.foto = new System.Windows.Forms.PictureBox();
            this.Apellidos = new System.Windows.Forms.Label();
            this.Apellido1 = new System.Windows.Forms.TextBox();
            this.Apellido2 = new System.Windows.Forms.TextBox();
            this.hombre = new System.Windows.Forms.RadioButton();
            this.mujer = new System.Windows.Forms.RadioButton();
            this.Sexo = new System.Windows.Forms.Label();
            this.imagenHombres = new System.Windows.Forms.PictureBox();
            this.textonombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenHombres)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(31, 239);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(75, 23);
            this.boton1.TabIndex = 0;
            this.boton1.Text = "&Enviar";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(31, 64);
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(100, 20);
            this.texto.TabIndex = 2;
            // 
            // foto
            // 
            this.foto.Image = ((System.Drawing.Image)(resources.GetObject("foto.Image")));
            this.foto.Location = new System.Drawing.Point(137, 48);
            this.foto.Name = "foto";
            this.foto.Size = new System.Drawing.Size(190, 242);
            this.foto.TabIndex = 4;
            this.foto.TabStop = false;
            this.foto.Visible = false;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSize = true;
            this.Apellidos.Location = new System.Drawing.Point(31, 91);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(49, 13);
            this.Apellidos.TabIndex = 6;
            this.Apellidos.Text = "Apellidos";
            // 
            // Apellido1
            // 
            this.Apellido1.Location = new System.Drawing.Point(31, 108);
            this.Apellido1.Name = "Apellido1";
            this.Apellido1.Size = new System.Drawing.Size(100, 20);
            this.Apellido1.TabIndex = 7;
            // 
            // Apellido2
            // 
            this.Apellido2.Location = new System.Drawing.Point(31, 131);
            this.Apellido2.Name = "Apellido2";
            this.Apellido2.Size = new System.Drawing.Size(100, 20);
            this.Apellido2.TabIndex = 8;
            // 
            // hombre
            // 
            this.hombre.AutoSize = true;
            this.hombre.Location = new System.Drawing.Point(31, 176);
            this.hombre.Name = "hombre";
            this.hombre.Size = new System.Drawing.Size(62, 17);
            this.hombre.TabIndex = 9;
            this.hombre.TabStop = true;
            this.hombre.Text = "Hombre";
            this.hombre.UseVisualStyleBackColor = true;
            // 
            // mujer
            // 
            this.mujer.AutoSize = true;
            this.mujer.Location = new System.Drawing.Point(31, 200);
            this.mujer.Name = "mujer";
            this.mujer.Size = new System.Drawing.Size(51, 17);
            this.mujer.TabIndex = 10;
            this.mujer.TabStop = true;
            this.mujer.Text = "Mujer";
            this.mujer.UseVisualStyleBackColor = true;
            // 
            // Sexo
            // 
            this.Sexo.AutoSize = true;
            this.Sexo.Location = new System.Drawing.Point(31, 157);
            this.Sexo.Name = "Sexo";
            this.Sexo.Size = new System.Drawing.Size(31, 13);
            this.Sexo.TabIndex = 11;
            this.Sexo.Text = "Sexo";
            // 
            // imagenHombres
            // 
            this.imagenHombres.Image = ((System.Drawing.Image)(resources.GetObject("imagenHombres.Image")));
            this.imagenHombres.Location = new System.Drawing.Point(137, 48);
            this.imagenHombres.Name = "imagenHombres";
            this.imagenHombres.Size = new System.Drawing.Size(190, 242);
            this.imagenHombres.TabIndex = 12;
            this.imagenHombres.TabStop = false;
            this.imagenHombres.Visible = false;
            // 
            // textonombre
            // 
            this.textonombre.AutoSize = true;
            this.textonombre.Location = new System.Drawing.Point(138, 48);
            this.textonombre.Name = "textonombre";
            this.textonombre.Size = new System.Drawing.Size(0, 13);
            this.textonombre.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 318);
            this.Controls.Add(this.textonombre);
            this.Controls.Add(this.imagenHombres);
            this.Controls.Add(this.Sexo);
            this.Controls.Add(this.mujer);
            this.Controls.Add(this.hombre);
            this.Controls.Add(this.Apellido2);
            this.Controls.Add(this.Apellido1);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.foto);
            this.Controls.Add(this.texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton1);
            this.Name = "Form1";
            this.Text = "Hello World C#";
            ((System.ComponentModel.ISupportInitialize)(this.foto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenHombres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.PictureBox foto;
        private System.Windows.Forms.Label Apellidos;
        private System.Windows.Forms.TextBox Apellido1;
        private System.Windows.Forms.TextBox Apellido2;
        private System.Windows.Forms.RadioButton hombre;
        private System.Windows.Forms.RadioButton mujer;
        private System.Windows.Forms.Label Sexo;
        private System.Windows.Forms.PictureBox imagenHombres;
        private System.Windows.Forms.Label textonombre;
    }
}

