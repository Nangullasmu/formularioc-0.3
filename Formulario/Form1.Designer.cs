namespace Formulario
{
    partial class FFormulario
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
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbapellido = new System.Windows.Forms.Label();
            this.lbtelefono = new System.Windows.Forms.Label();
            this.lbestatura = new System.Windows.Forms.Label();
            this.lbedad = new System.Windows.Forms.Label();
            this.gbgenero = new System.Windows.Forms.GroupBox();
            this.cbmujer = new System.Windows.Forms.CheckBox();
            this.cbhombre = new System.Windows.Forms.CheckBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbestatura = new System.Windows.Forms.TextBox();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.btguardar = new System.Windows.Forms.Button();
            this.btcancerlar = new System.Windows.Forms.Button();
            this.gbgenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Location = new System.Drawing.Point(95, 12);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(47, 13);
            this.lbnombre.TabIndex = 0;
            this.lbnombre.Text = "Nombre:";
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Location = new System.Drawing.Point(95, 51);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(47, 13);
            this.lbapellido.TabIndex = 1;
            this.lbapellido.Text = "Apellido:";
            // 
            // lbtelefono
            // 
            this.lbtelefono.AutoSize = true;
            this.lbtelefono.Location = new System.Drawing.Point(95, 90);
            this.lbtelefono.Name = "lbtelefono";
            this.lbtelefono.Size = new System.Drawing.Size(52, 13);
            this.lbtelefono.TabIndex = 2;
            this.lbtelefono.Text = "Telefono:";
            // 
            // lbestatura
            // 
            this.lbestatura.AutoSize = true;
            this.lbestatura.Location = new System.Drawing.Point(95, 129);
            this.lbestatura.Name = "lbestatura";
            this.lbestatura.Size = new System.Drawing.Size(49, 13);
            this.lbestatura.TabIndex = 3;
            this.lbestatura.Text = "Estatura:";
            // 
            // lbedad
            // 
            this.lbedad.AutoSize = true;
            this.lbedad.Location = new System.Drawing.Point(95, 168);
            this.lbedad.Name = "lbedad";
            this.lbedad.Size = new System.Drawing.Size(35, 13);
            this.lbedad.TabIndex = 4;
            this.lbedad.Text = "Edad:";
            // 
            // gbgenero
            // 
            this.gbgenero.Controls.Add(this.cbmujer);
            this.gbgenero.Controls.Add(this.cbhombre);
            this.gbgenero.Location = new System.Drawing.Point(98, 202);
            this.gbgenero.Name = "gbgenero";
            this.gbgenero.Size = new System.Drawing.Size(150, 48);
            this.gbgenero.TabIndex = 5;
            this.gbgenero.TabStop = false;
            this.gbgenero.Text = "Genero";
            // 
            // cbmujer
            // 
            this.cbmujer.AutoSize = true;
            this.cbmujer.Location = new System.Drawing.Point(92, 19);
            this.cbmujer.Name = "cbmujer";
            this.cbmujer.Size = new System.Drawing.Size(52, 17);
            this.cbmujer.TabIndex = 1;
            this.cbmujer.Text = "Mujer";
            this.cbmujer.UseVisualStyleBackColor = true;
            // 
            // cbhombre
            // 
            this.cbhombre.AutoSize = true;
            this.cbhombre.Location = new System.Drawing.Point(6, 19);
            this.cbhombre.Name = "cbhombre";
            this.cbhombre.Size = new System.Drawing.Size(63, 17);
            this.cbhombre.TabIndex = 0;
            this.cbhombre.Text = "Hombre";
            this.cbhombre.UseVisualStyleBackColor = true;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(148, 12);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 6;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(148, 51);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 20);
            this.tbapellido.TabIndex = 7;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(148, 87);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 20);
            this.tbtelefono.TabIndex = 8;
            // 
            // tbestatura
            // 
            this.tbestatura.Location = new System.Drawing.Point(148, 129);
            this.tbestatura.Name = "tbestatura";
            this.tbestatura.Size = new System.Drawing.Size(100, 20);
            this.tbestatura.TabIndex = 9;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(148, 165);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(100, 20);
            this.tbedad.TabIndex = 10;
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(98, 256);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(150, 23);
            this.btguardar.TabIndex = 11;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            // 
            // btcancerlar
            // 
            this.btcancerlar.Location = new System.Drawing.Point(98, 295);
            this.btcancerlar.Name = "btcancerlar";
            this.btcancerlar.Size = new System.Drawing.Size(150, 23);
            this.btcancerlar.TabIndex = 12;
            this.btcancerlar.Text = "Cancelar";
            this.btcancerlar.UseVisualStyleBackColor = true;
            this.btcancerlar.Click += new System.EventHandler(this.btcancerlar_Click);
            // 
            // FFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btcancerlar);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbestatura);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.gbgenero);
            this.Controls.Add(this.lbedad);
            this.Controls.Add(this.lbestatura);
            this.Controls.Add(this.lbtelefono);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.lbnombre);
            this.Name = "FFormulario";
            this.Text = "Formulario";
            this.gbgenero.ResumeLayout(false);
            this.gbgenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbapellido;
        private System.Windows.Forms.Label lbtelefono;
        private System.Windows.Forms.Label lbestatura;
        private System.Windows.Forms.Label lbedad;
        private System.Windows.Forms.GroupBox gbgenero;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.CheckBox cbmujer;
        private System.Windows.Forms.CheckBox cbhombre;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbestatura;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.Button btcancerlar;
    }
}