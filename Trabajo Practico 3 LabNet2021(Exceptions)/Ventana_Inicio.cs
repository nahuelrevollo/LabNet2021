using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using BL_Negocio;

namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    public partial class Ventana_Inicio : Form
    {

        Numeros Dto_Numero = new Numeros();
        public Ventana_Inicio()
        {
            InitializeComponent();
        }

        private void Btn_Punto1_Click(object sender, EventArgs e)
        {

            try
            {

                FrmPunto_1 Ventana_Punto1 = new FrmPunto_1();

                Ventana_Punto1.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }


        }

        private void Btn_Punto2_Click(object sender, EventArgs e)
        {
            try
            {

                FrmPunto_2 Ventana_Punto2 = new FrmPunto_2();

                Ventana_Punto2.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }

        }

        private void BtnPunto3_Click(object sender, EventArgs e)
        {

            try
            {

                FrmPunto_3 Ventana_Punto3 = new FrmPunto_3();

                Ventana_Punto3.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }

        }

        private void BtnPunto4_Click(object sender, EventArgs e)
        {
            try
            {

                FrmPunto_4 Ventana_Punto4 = new FrmPunto_4();

                Ventana_Punto4.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);


            }
        }
    }
}
