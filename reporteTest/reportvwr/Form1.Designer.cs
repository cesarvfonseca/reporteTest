namespace reportvwr
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
            this.btnVer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(12, 12);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(152, 37);
            this.btnVer.TabIndex = 0;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 61);
            this.Controls.Add(this.btnVer);
            this.Name = "Form1";
            this.Text = "Hitomi";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVer;
    }
}

