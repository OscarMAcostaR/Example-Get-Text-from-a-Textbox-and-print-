namespace Obtener_Texto_de_un_Texbox_e_imprimir
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInformacion = new System.Windows.Forms.TextBox();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.TxtInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escribe tu Edad";
            // 
            // TxtInformacion
            // 
            this.TxtInformacion.Location = new System.Drawing.Point(39, 117);
            this.TxtInformacion.Name = "TxtInformacion";
            this.TxtInformacion.Size = new System.Drawing.Size(158, 20);
            this.TxtInformacion.TabIndex = 1;
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(54, 159);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(158, 23);
            this.BtnMostrar.TabIndex = 2;
            this.BtnMostrar.Text = "Imprimir";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // TxtInfo
            // 
            this.TxtInfo.Location = new System.Drawing.Point(39, 63);
            this.TxtInfo.Name = "TxtInfo";
            this.TxtInfo.Size = new System.Drawing.Size(158, 20);
            this.TxtInfo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Completo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 194);
            this.Controls.Add(this.TxtInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.TxtInformacion);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInformacion;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.TextBox TxtInfo;
        private System.Windows.Forms.Label label2;
    }
}

