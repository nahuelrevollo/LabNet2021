namespace TRABAJO_PRACTICO_2_LABSNET2021
{
    partial class TP2_Inicio
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
            this.lblTransportes = new System.Windows.Forms.Label();
            this.btnAviones = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAutos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTransportes
            // 
            this.lblTransportes.AutoSize = true;
            this.lblTransportes.Location = new System.Drawing.Point(343, 43);
            this.lblTransportes.Name = "lblTransportes";
            this.lblTransportes.Size = new System.Drawing.Size(103, 13);
            this.lblTransportes.TabIndex = 0;
            this.lblTransportes.Text = "Guia de Transportes";
            // 
            // btnAviones
            // 
            this.btnAviones.Location = new System.Drawing.Point(316, 96);
            this.btnAviones.Name = "btnAviones";
            this.btnAviones.Size = new System.Drawing.Size(147, 57);
            this.btnAviones.TabIndex = 1;
            this.btnAviones.Text = "Aviones";
            this.btnAviones.UseVisualStyleBackColor = true;
            this.btnAviones.Click += new System.EventHandler(this.btnAviones_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(215, 248);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 173);
            this.listBox1.TabIndex = 3;
            // 
            // btnAutos
            // 
            this.btnAutos.Location = new System.Drawing.Point(316, 176);
            this.btnAutos.Name = "btnAutos";
            this.btnAutos.Size = new System.Drawing.Size(147, 57);
            this.btnAutos.TabIndex = 4;
            this.btnAutos.Text = "Automoviles";
            this.btnAutos.UseVisualStyleBackColor = true;
            this.btnAutos.Click += new System.EventHandler(this.btnAutos_Click);
            // 
            // TP2_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAutos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAviones);
            this.Controls.Add(this.lblTransportes);
            this.Name = "TP2_Inicio";
            this.Text = "LabNet2021";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTransportes;
        private System.Windows.Forms.Button btnAviones;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAutos;
    }
}

