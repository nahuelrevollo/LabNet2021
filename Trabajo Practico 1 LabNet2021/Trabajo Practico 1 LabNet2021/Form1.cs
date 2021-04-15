using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_1_LabNet2021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            

        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo","Saludo",MessageBoxButtons.OK,MessageBoxIcon.Information) ;
        }
    }
}
