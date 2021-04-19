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
    public partial class FrmPunto_2 : Form
    {
        public FrmPunto_2()
        {
            InitializeComponent();
        }

        private void BtnDividir_Click(object sender, EventArgs e)
        {
            Numeros Dto_Numero = new Numeros();
            BL_Numeros BL_Numero = new BL_Numeros();
            int ResultadoDivision;
            

            try
            {
                Dto_Numero.Valor1 = int.Parse(TxtDividendo.Text);
                Dto_Numero.Valor2 = int.Parse(TxtDivisor.Text);

                ResultadoDivision = BL_Numero.DividirNumeros(Dto_Numero.Valor1, Dto_Numero.Valor2);

                DialogResult result= MessageBox.Show("El Resultado es: " + ResultadoDivision, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if(result==DialogResult.OK)
                {
                    TxtDividendo.Text = "";
                    TxtDivisor.Text = "";



                }
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show( ex.Message);
            }
            catch(FormatException)

            {
                DialogResult result = MessageBox.Show("Seguro Ingreso una letra o no ingreso nada!", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                

                    if (result == DialogResult.OK)
                {
                    TxtDividendo.Text = "";
                    TxtDivisor.Text = "";



                }
            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
