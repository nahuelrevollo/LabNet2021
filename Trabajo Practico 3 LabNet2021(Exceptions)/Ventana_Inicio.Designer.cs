namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    partial class Ventana_Inicio
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
            this.Btn_Punto1 = new System.Windows.Forms.Button();
            this.Btn_Punto2 = new System.Windows.Forms.Button();
            this.BtnPunto3 = new System.Windows.Forms.Button();
            this.BtnPunto4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Punto1
            // 
            this.Btn_Punto1.Location = new System.Drawing.Point(312, 62);
            this.Btn_Punto1.Name = "Btn_Punto1";
            this.Btn_Punto1.Size = new System.Drawing.Size(183, 58);
            this.Btn_Punto1.TabIndex = 0;
            this.Btn_Punto1.Text = "Punto1";
            this.Btn_Punto1.UseVisualStyleBackColor = true;
            this.Btn_Punto1.Click += new System.EventHandler(this.Btn_Punto1_Click);
            // 
            // Btn_Punto2
            // 
            this.Btn_Punto2.Location = new System.Drawing.Point(312, 158);
            this.Btn_Punto2.Name = "Btn_Punto2";
            this.Btn_Punto2.Size = new System.Drawing.Size(183, 58);
            this.Btn_Punto2.TabIndex = 1;
            this.Btn_Punto2.Text = "Punto2";
            this.Btn_Punto2.UseVisualStyleBackColor = true;
            this.Btn_Punto2.Click += new System.EventHandler(this.Btn_Punto2_Click);
            // 
            // BtnPunto3
            // 
            this.BtnPunto3.Location = new System.Drawing.Point(312, 248);
            this.BtnPunto3.Name = "BtnPunto3";
            this.BtnPunto3.Size = new System.Drawing.Size(180, 56);
            this.BtnPunto3.TabIndex = 2;
            this.BtnPunto3.Text = "Punto 3";
            this.BtnPunto3.UseVisualStyleBackColor = true;
            this.BtnPunto3.Click += new System.EventHandler(this.BtnPunto3_Click);
            // 
            // BtnPunto4
            // 
            this.BtnPunto4.Location = new System.Drawing.Point(312, 358);
            this.BtnPunto4.Name = "BtnPunto4";
            this.BtnPunto4.Size = new System.Drawing.Size(179, 54);
            this.BtnPunto4.TabIndex = 3;
            this.BtnPunto4.Text = "Punto4";
            this.BtnPunto4.UseVisualStyleBackColor = true;
            this.BtnPunto4.Click += new System.EventHandler(this.BtnPunto4_Click);
            // 
            // Ventana_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnPunto4);
            this.Controls.Add(this.BtnPunto3);
            this.Controls.Add(this.Btn_Punto2);
            this.Controls.Add(this.Btn_Punto1);
            this.Name = "Ventana_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LabNet2021";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Punto1;
        private System.Windows.Forms.Button Btn_Punto2;
        private System.Windows.Forms.Button BtnPunto3;
        private System.Windows.Forms.Button BtnPunto4;
    }
}

