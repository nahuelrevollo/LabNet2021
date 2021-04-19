﻿using System;
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
    public partial class FrmPunto_4 : Form
    {
        public FrmPunto_4()
        {
            InitializeComponent();
        }

        private void BtnDividirPunto4_Click(object sender, EventArgs e)
        {
            Numeros Dto_Numero = new Numeros();
            BL_Numeros BL_Numero = new BL_Numeros();
            BL_Logic BL_LogicEx = new BL_Logic();


            try
            {
                Dto_Numero.Valor1 = int.Parse(TxtPunto4.Text);

                BL_Numero.Dividir_X_Cero(Dto_Numero.Valor1);


            }
            catch (Exception ex)
            {


                MessageBox.Show(BL_LogicEx.Message+". Aca Resuelvo punto4");


            }
        }

        private void BtnSalirPunto4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
