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

namespace TRABAJO_PRACTICO_2_LABSNET2021
{
    public partial class TP2_Inicio : Form
    {
        public TP2_Inicio()
        {
            InitializeComponent();
        }


        List<Avion> List_Aviones = new List<Avion>();
        List<Automovil> Listado_Automoviles = new List<Automovil>();
        int numTransporte = 0;

        

        private void btnAviones_Click(object sender, EventArgs e)
        {


            Avion avion1 = new Avion(120);
            Avion avion2 = new Avion(200);
            Avion avion3 = new Avion(320);
            Avion avion4 = new Avion(420);
            Avion avion5 = new Avion(270);



            List_Aviones.Add(avion1);
            List_Aviones.Add(avion2);
            List_Aviones.Add(avion3);
            List_Aviones.Add(avion4);
            List_Aviones.Add(avion5);



            foreach (var item in List_Aviones)
            {
                numTransporte++;



                if (numTransporte > 5)

                {

                    listBox1.Items.Clear();

                    numTransporte = 0;



                }
                else if (numTransporte <= 5)
                {

                    listBox1.Items.Add(("Avion " + numTransporte + ": Cantidad de pasajeros" + item.Pasajeros));

                }



            }


        }

        private void btnAutos_Click(object sender, EventArgs e)
        {



            Automovil Automovil1 = new Automovil(2);
            Automovil Automovil2 = new Automovil(1);
            Automovil Automovil3 = new Automovil(4);
            Automovil Automovil4 = new Automovil(5);
            Automovil Automovil5 = new Automovil(3);



            Listado_Automoviles.Add(Automovil1);
            Listado_Automoviles.Add(Automovil2);
            Listado_Automoviles.Add(Automovil3);
            Listado_Automoviles.Add(Automovil4);
            Listado_Automoviles.Add(Automovil5);




            foreach (var item in Listado_Automoviles)
            {

                numTransporte++;



                if (numTransporte > 5)

                {

                    listBox1.Items.Clear();
                    numTransporte = 0;

                }
                else if (numTransporte <= 5)
                {

                    listBox1.Items.Add(("Auto " + numTransporte + ": Cantidad de pasajeros" + item.Pasajeros));

                }


            }



        }
    }
}
