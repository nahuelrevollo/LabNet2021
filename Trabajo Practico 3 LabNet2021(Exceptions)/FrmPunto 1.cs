using BL_Negocio;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabajo_Practico_3_LabNet2021_Exceptions_
{
    public partial class FrmPunto_1 : Form
    {
        public FrmPunto_1()
        {
            InitializeComponent();
        }

        private void Btn_Dividir_Click(object sender, EventArgs e)
        {
            Numeros Dto_Numero = new Numeros();
            BL_Numeros BL_Numero = new BL_Numeros();


            try
            {
                Dto_Numero.Valor1 =int.Parse(Txt_IngresarNumero.Text);

                BL_Numero.Dividir_X_Cero(Dto_Numero.Valor1);


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
