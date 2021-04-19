namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    partial class FrmPunto_1
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
            this.Txt_IngresarNumero = new System.Windows.Forms.TextBox();
            this.Lbl_TituloPunto1 = new System.Windows.Forms.Label();
            this.Btn_Dividir = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_IngresarNumero
            // 
            this.Txt_IngresarNumero.Location = new System.Drawing.Point(257, 147);
            this.Txt_IngresarNumero.Name = "Txt_IngresarNumero";
            this.Txt_IngresarNumero.Size = new System.Drawing.Size(201, 20);
            this.Txt_IngresarNumero.TabIndex = 0;
            // 
            // Lbl_TituloPunto1
            // 
            this.Lbl_TituloPunto1.AutoSize = true;
            this.Lbl_TituloPunto1.Location = new System.Drawing.Point(284, 98);
            this.Lbl_TituloPunto1.Name = "Lbl_TituloPunto1";
            this.Lbl_TituloPunto1.Size = new System.Drawing.Size(149, 13);
            this.Lbl_TituloPunto1.TabIndex = 1;
            this.Lbl_TituloPunto1.Text = "Ingrese un numero para dividir";
            // 
            // Btn_Dividir
            // 
            this.Btn_Dividir.Location = new System.Drawing.Point(180, 220);
            this.Btn_Dividir.Name = "Btn_Dividir";
            this.Btn_Dividir.Size = new System.Drawing.Size(148, 29);
            this.Btn_Dividir.TabIndex = 2;
            this.Btn_Dividir.Text = "Dividir";
            this.Btn_Dividir.UseVisualStyleBackColor = true;
            this.Btn_Dividir.Click += new System.EventHandler(this.Btn_Dividir_Click);
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.Location = new System.Drawing.Point(381, 220);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(148, 29);
            this.Btn_Salir.TabIndex = 3;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // FrmPunto_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Salir);
            this.Controls.Add(this.Btn_Dividir);
            this.Controls.Add(this.Lbl_TituloPunto1);
            this.Controls.Add(this.Txt_IngresarNumero);
            this.Name = "FrmPunto_1";
            this.Text = "Punto_1 LabNet2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_IngresarNumero;
        private System.Windows.Forms.Label Lbl_TituloPunto1;
        private System.Windows.Forms.Button Btn_Dividir;
        private System.Windows.Forms.Button Btn_Salir;
    }
}