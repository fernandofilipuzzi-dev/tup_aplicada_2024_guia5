namespace Ejercicio1
{
    partial class FormVer
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
            this.btnPrueba = new System.Windows.Forms.Button();
            this.lbxVer = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrueba
            // 
            this.btnPrueba.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPrueba.Location = new System.Drawing.Point(160, 253);
            this.btnPrueba.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrueba.Name = "btnPrueba";
            this.btnPrueba.Size = new System.Drawing.Size(112, 35);
            this.btnPrueba.TabIndex = 3;
            this.btnPrueba.Text = "Cerrar";
            this.btnPrueba.UseVisualStyleBackColor = true;
            this.btnPrueba.Click += new System.EventHandler(this.btnPrueba_Click);
            // 
            // lbxVer
            // 
            this.lbxVer.FormattingEnabled = true;
            this.lbxVer.ItemHeight = 20;
            this.lbxVer.Location = new System.Drawing.Point(12, 1);
            this.lbxVer.Name = "lbxVer";
            this.lbxVer.Size = new System.Drawing.Size(404, 244);
            this.lbxVer.TabIndex = 4;
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 295);
            this.Controls.Add(this.lbxVer);
            this.Controls.Add(this.btnPrueba);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Resultados";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrueba;
        public System.Windows.Forms.ListBox lbxVer;
    }
}