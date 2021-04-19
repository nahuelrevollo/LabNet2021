namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    partial class FrmPunto_4
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
            this.LblTituloPunto4 = new System.Windows.Forms.Label();
            this.TxtPunto4 = new System.Windows.Forms.TextBox();
            this.BtnDividirPunto4 = new System.Windows.Forms.Button();
            this.BtnSalirPunto4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTituloPunto4
            // 
            this.LblTituloPunto4.AutoSize = true;
            this.LblTituloPunto4.Location = new System.Drawing.Point(289, 32);
            this.LblTituloPunto4.Name = "LblTituloPunto4";
            this.LblTituloPunto4.Size = new System.Drawing.Size(134, 13);
            this.LblTituloPunto4.TabIndex = 0;
            this.LblTituloPunto4.Text = "Ingrese numero para dividir";
            // 
            // TxtPunto4
            // 
            this.TxtPunto4.Location = new System.Drawing.Point(292, 106);
            this.TxtPunto4.Name = "TxtPunto4";
            this.TxtPunto4.Size = new System.Drawing.Size(130, 20);
            this.TxtPunto4.TabIndex = 1;
            // 
            // BtnDividirPunto4
            // 
            this.BtnDividirPunto4.Location = new System.Drawing.Point(182, 177);
            this.BtnDividirPunto4.Name = "BtnDividirPunto4";
            this.BtnDividirPunto4.Size = new System.Drawing.Size(122, 41);
            this.BtnDividirPunto4.TabIndex = 2;
            this.BtnDividirPunto4.Text = "Dividir";
            this.BtnDividirPunto4.UseVisualStyleBackColor = true;
            this.BtnDividirPunto4.Click += new System.EventHandler(this.BtnDividirPunto4_Click);
            // 
            // BtnSalirPunto4
            // 
            this.BtnSalirPunto4.Location = new System.Drawing.Point(437, 177);
            this.BtnSalirPunto4.Name = "BtnSalirPunto4";
            this.BtnSalirPunto4.Size = new System.Drawing.Size(122, 41);
            this.BtnSalirPunto4.TabIndex = 3;
            this.BtnSalirPunto4.Text = "Salir";
            this.BtnSalirPunto4.UseVisualStyleBackColor = true;
            this.BtnSalirPunto4.Click += new System.EventHandler(this.BtnSalirPunto4_Click);
            // 
            // FrmPunto_4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalirPunto4);
            this.Controls.Add(this.BtnDividirPunto4);
            this.Controls.Add(this.TxtPunto4);
            this.Controls.Add(this.LblTituloPunto4);
            this.Name = "FrmPunto_4";
            this.Text = "Punto_4 LabNet2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTituloPunto4;
        private System.Windows.Forms.TextBox TxtPunto4;
        private System.Windows.Forms.Button BtnDividirPunto4;
        private System.Windows.Forms.Button BtnSalirPunto4;
    }
}