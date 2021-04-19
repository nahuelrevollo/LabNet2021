namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    partial class FrmPunto_2
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
            this.LblTituloPunto2 = new System.Windows.Forms.Label();
            this.LblDividendo = new System.Windows.Forms.Label();
            this.LblDivisor = new System.Windows.Forms.Label();
            this.TxtDividendo = new System.Windows.Forms.TextBox();
            this.TxtDivisor = new System.Windows.Forms.TextBox();
            this.BtnDividir = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTituloPunto2
            // 
            this.LblTituloPunto2.AutoSize = true;
            this.LblTituloPunto2.Location = new System.Drawing.Point(286, 53);
            this.LblTituloPunto2.Name = "LblTituloPunto2";
            this.LblTituloPunto2.Size = new System.Drawing.Size(151, 13);
            this.LblTituloPunto2.TabIndex = 0;
            this.LblTituloPunto2.Text = "Ingresar 2 numeros para dividir";
            // 
            // LblDividendo
            // 
            this.LblDividendo.AutoSize = true;
            this.LblDividendo.Location = new System.Drawing.Point(203, 142);
            this.LblDividendo.Name = "LblDividendo";
            this.LblDividendo.Size = new System.Drawing.Size(55, 13);
            this.LblDividendo.TabIndex = 1;
            this.LblDividendo.Text = "Dividendo";
            // 
            // LblDivisor
            // 
            this.LblDivisor.AutoSize = true;
            this.LblDivisor.Location = new System.Drawing.Point(203, 195);
            this.LblDivisor.Name = "LblDivisor";
            this.LblDivisor.Size = new System.Drawing.Size(39, 13);
            this.LblDivisor.TabIndex = 2;
            this.LblDivisor.Text = "Divisor";
            // 
            // TxtDividendo
            // 
            this.TxtDividendo.Location = new System.Drawing.Point(300, 139);
            this.TxtDividendo.Name = "TxtDividendo";
            this.TxtDividendo.Size = new System.Drawing.Size(126, 20);
            this.TxtDividendo.TabIndex = 3;
            // 
            // TxtDivisor
            // 
            this.TxtDivisor.Location = new System.Drawing.Point(300, 188);
            this.TxtDivisor.Name = "TxtDivisor";
            this.TxtDivisor.Size = new System.Drawing.Size(126, 20);
            this.TxtDivisor.TabIndex = 4;
            // 
            // BtnDividir
            // 
            this.BtnDividir.Location = new System.Drawing.Point(197, 276);
            this.BtnDividir.Name = "BtnDividir";
            this.BtnDividir.Size = new System.Drawing.Size(94, 34);
            this.BtnDividir.TabIndex = 5;
            this.BtnDividir.Text = "Dividir";
            this.BtnDividir.UseVisualStyleBackColor = true;
            this.BtnDividir.Click += new System.EventHandler(this.BtnDividir_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.Location = new System.Drawing.Point(432, 276);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(94, 34);
            this.BtnSalir.TabIndex = 6;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // FrmPunto_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnDividir);
            this.Controls.Add(this.TxtDivisor);
            this.Controls.Add(this.TxtDividendo);
            this.Controls.Add(this.LblDivisor);
            this.Controls.Add(this.LblDividendo);
            this.Controls.Add(this.LblTituloPunto2);
            this.Name = "FrmPunto_2";
            this.Text = "Punto_2 LabNet2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloPunto2;
        private System.Windows.Forms.Label LblDividendo;
        private System.Windows.Forms.Label LblDivisor;
        private System.Windows.Forms.TextBox TxtDividendo;
        private System.Windows.Forms.TextBox TxtDivisor;
        private System.Windows.Forms.Button BtnDividir;
        private System.Windows.Forms.Button BtnSalir;
    }
}