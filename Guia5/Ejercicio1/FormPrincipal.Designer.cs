namespace Ejercicio1
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCerrarPresupuesto = new System.Windows.Forms.Button();
            this.btnBorrarProducto = new System.Windows.Forms.Button();
            this.btnIniciarPrespuesto = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbConsumos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbMesa = new System.Windows.Forms.RadioButton();
            this.rbBanco = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tbAncho = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.gbCargaConsumos = new System.Windows.Forms.GroupBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.lbDescripcionPeriodo = new System.Windows.Forms.Label();
            this.gbConsumos.SuspendLayout();
            this.gbCargaConsumos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCerrarPresupuesto
            // 
            this.btnCerrarPresupuesto.Location = new System.Drawing.Point(158, 115);
            this.btnCerrarPresupuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarPresupuesto.Name = "btnCerrarPresupuesto";
            this.btnCerrarPresupuesto.Size = new System.Drawing.Size(118, 59);
            this.btnCerrarPresupuesto.TabIndex = 0;
            this.btnCerrarPresupuesto.Text = "Cerrar Presupuesto";
            this.btnCerrarPresupuesto.UseVisualStyleBackColor = true;
            this.btnCerrarPresupuesto.Click += new System.EventHandler(this.btnCerrarPresupuesto_Click);
            // 
            // btnBorrarProducto
            // 
            this.btnBorrarProducto.Location = new System.Drawing.Point(157, 183);
            this.btnBorrarProducto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrarProducto.Name = "btnBorrarProducto";
            this.btnBorrarProducto.Size = new System.Drawing.Size(118, 35);
            this.btnBorrarProducto.TabIndex = 3;
            this.btnBorrarProducto.Text = "Borrar";
            this.btnBorrarProducto.UseVisualStyleBackColor = true;
            this.btnBorrarProducto.Click += new System.EventHandler(this.btnBorrarProducto_Click);
            // 
            // btnIniciarPrespuesto
            // 
            this.btnIniciarPrespuesto.Location = new System.Drawing.Point(21, 115);
            this.btnIniciarPrespuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIniciarPrespuesto.Name = "btnIniciarPrespuesto";
            this.btnIniciarPrespuesto.Size = new System.Drawing.Size(129, 59);
            this.btnIniciarPrespuesto.TabIndex = 5;
            this.btnIniciarPrespuesto.Text = "Iniciar Presupuesto";
            this.btnIniciarPrespuesto.UseVisualStyleBackColor = true;
            this.btnIniciarPrespuesto.Click += new System.EventHandler(this.btnIniciarPrespuesto_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(228, 107);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(125, 41);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(91, 29);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(152, 26);
            this.tbNombre.TabIndex = 11;
            // 
            // gbConsumos
            // 
            this.gbConsumos.Controls.Add(this.label6);
            this.gbConsumos.Controls.Add(this.label5);
            this.gbConsumos.Controls.Add(this.label4);
            this.gbConsumos.Controls.Add(this.label3);
            this.gbConsumos.Controls.Add(this.rbMesa);
            this.gbConsumos.Controls.Add(this.rbBanco);
            this.gbConsumos.Controls.Add(this.label2);
            this.gbConsumos.Controls.Add(this.textBox6);
            this.gbConsumos.Controls.Add(this.textBox5);
            this.gbConsumos.Controls.Add(this.textBox4);
            this.gbConsumos.Controls.Add(this.tbAncho);
            this.gbConsumos.Controls.Add(this.tbPrecio);
            this.gbConsumos.Controls.Add(this.btnAgregar);
            this.gbConsumos.Enabled = false;
            this.gbConsumos.Location = new System.Drawing.Point(319, 14);
            this.gbConsumos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConsumos.Name = "gbConsumos";
            this.gbConsumos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbConsumos.Size = new System.Drawing.Size(365, 225);
            this.gbConsumos.TabIndex = 12;
            this.gbConsumos.TabStop = false;
            this.gbConsumos.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 68);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Grosor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(191, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Largo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ancho:";
            // 
            // rbMesa
            // 
            this.rbMesa.AutoSize = true;
            this.rbMesa.Location = new System.Drawing.Point(26, 180);
            this.rbMesa.Name = "rbMesa";
            this.rbMesa.Size = new System.Drawing.Size(66, 24);
            this.rbMesa.TabIndex = 23;
            this.rbMesa.TabStop = true;
            this.rbMesa.Text = "Mesa";
            this.rbMesa.UseVisualStyleBackColor = true;
            // 
            // rbBanco
            // 
            this.rbBanco.AutoSize = true;
            this.rbBanco.Location = new System.Drawing.Point(26, 150);
            this.rbBanco.Name = "rbBanco";
            this.rbBanco.Size = new System.Drawing.Size(73, 24);
            this.rbBanco.TabIndex = 22;
            this.rbBanco.TabStop = true;
            this.rbBanco.Text = "Banco";
            this.rbBanco.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Precio B:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(261, 68);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(92, 26);
            this.textBox6.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(261, 29);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(92, 26);
            this.textBox5.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(82, 104);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(92, 26);
            this.textBox4.TabIndex = 17;
            // 
            // tbAncho
            // 
            this.tbAncho.Location = new System.Drawing.Point(82, 68);
            this.tbAncho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbAncho.Name = "tbAncho";
            this.tbAncho.Size = new System.Drawing.Size(92, 26);
            this.tbAncho.TabIndex = 16;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(82, 29);
            this.tbPrecio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(92, 26);
            this.tbPrecio.TabIndex = 12;
            // 
            // gbCargaConsumos
            // 
            this.gbCargaConsumos.Controls.Add(this.cmbProducto);
            this.gbCargaConsumos.Controls.Add(this.label1);
            this.gbCargaConsumos.Controls.Add(this.tbDireccion);
            this.gbCargaConsumos.Controls.Add(this.lbDescripcionPeriodo);
            this.gbCargaConsumos.Controls.Add(this.tbNombre);
            this.gbCargaConsumos.Controls.Add(this.btnCerrarPresupuesto);
            this.gbCargaConsumos.Controls.Add(this.btnBorrarProducto);
            this.gbCargaConsumos.Controls.Add(this.btnIniciarPrespuesto);
            this.gbCargaConsumos.Enabled = false;
            this.gbCargaConsumos.Location = new System.Drawing.Point(13, 14);
            this.gbCargaConsumos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaConsumos.Name = "gbCargaConsumos";
            this.gbCargaConsumos.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCargaConsumos.Size = new System.Drawing.Size(298, 225);
            this.gbCargaConsumos.TabIndex = 11;
            this.gbCargaConsumos.TabStop = false;
            this.gbCargaConsumos.Text = "Cliente";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(29, 187);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(121, 28);
            this.cmbProducto.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Direccion";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(91, 65);
            this.tbDireccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(152, 26);
            this.tbDireccion.TabIndex = 13;
            // 
            // lbDescripcionPeriodo
            // 
            this.lbDescripcionPeriodo.AutoSize = true;
            this.lbDescripcionPeriodo.Location = new System.Drawing.Point(8, 29);
            this.lbDescripcionPeriodo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDescripcionPeriodo.Name = "lbDescripcionPeriodo";
            this.lbDescripcionPeriodo.Size = new System.Drawing.Size(65, 20);
            this.lbDescripcionPeriodo.TabIndex = 12;
            this.lbDescripcionPeriodo.Text = "Nombre";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 252);
            this.Controls.Add(this.gbConsumos);
            this.Controls.Add(this.gbCargaConsumos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.gbConsumos.ResumeLayout(false);
            this.gbConsumos.PerformLayout();
            this.gbCargaConsumos.ResumeLayout(false);
            this.gbCargaConsumos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarPresupuesto;
        private System.Windows.Forms.Button btnBorrarProducto;
        private System.Windows.Forms.Button btnIniciarPrespuesto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox gbCargaConsumos;
        private System.Windows.Forms.GroupBox gbConsumos;
        private System.Windows.Forms.Label lbDescripcionPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tbAncho;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbMesa;
        private System.Windows.Forms.RadioButton rbBanco;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

