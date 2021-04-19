namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    partial class FrmPunto_3
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
            this.LblTituloPunto3 = new System.Windows.Forms.Label();
            this.TxtPunto3 = new System.Windows.Forms.TextBox();
            this.BtnDividirPunto3 = new System.Windows.Forms.Button();
            this.BtnSalirPunto3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTituloPunto3
            // 
            this.LblTituloPunto3.AutoSize = true;
            this.LblTituloPunto3.Location = new System.Drawing.Point(308, 43);
            this.LblTituloPunto3.Name = "LblTituloPunto3";
            this.LblTituloPunto3.Size = new System.Drawing.Size(149, 13);
            this.LblTituloPunto3.TabIndex = 0;
            this.LblTituloPunto3.Text = "Ingrese un numero para dividir";
            // 
            // TxtPunto3
            // 
            this.TxtPunto3.Location = new System.Drawing.Point(282, 95);
            this.TxtPunto3.Name = "TxtPunto3";
            this.TxtPunto3.Size = new System.Drawing.Size(188, 20);
            this.TxtPunto3.TabIndex = 1;
            // 
            // BtnDividirPunto3
            // 
            this.BtnDividirPunto3.Location = new System.Drawing.Point(208, 162);
            this.BtnDividirPunto3.Name = "BtnDividirPunto3";
            this.BtnDividirPunto3.Size = new System.Drawing.Size(161, 29);
            this.BtnDividirPunto3.TabIndex = 2;
            this.BtnDividirPunto3.Text = "Dividir";
            this.BtnDividirPunto3.UseVisualStyleBackColor = true;
            this.BtnDividirPunto3.Click += new System.EventHandler(this.BtnDividirPunto3_Click);
            // 
            // BtnSalirPunto3
            // 
            this.BtnSalirPunto3.Location = new System.Drawing.Point(407, 162);
            this.BtnSalirPunto3.Name = "BtnSalirPunto3";
            this.BtnSalirPunto3.Size = new System.Drawing.Size(161, 29);
            this.BtnSalirPunto3.TabIndex = 3;
            this.BtnSalirPunto3.Text = "Salir";
            this.BtnSalirPunto3.UseVisualStyleBackColor = true;
            this.BtnSalirPunto3.Click += new System.EventHandler(this.BtnSalirPunto3_Click);
            // 
            // FrmPunto_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalirPunto3);
            this.Controls.Add(this.BtnDividirPunto3);
            this.Controls.Add(this.TxtPunto3);
            this.Controls.Add(this.LblTituloPunto3);
            this.Name = "FrmPunto_3";
            this.Text = "Punto_3 LabNet2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloPunto3;
        private System.Windows.Forms.TextBox TxtPunto3;
        private System.Windows.Forms.Button BtnDividirPunto3;
        private System.Windows.Forms.Button BtnSalirPunto3;
    }
}