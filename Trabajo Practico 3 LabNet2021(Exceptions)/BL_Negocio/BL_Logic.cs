using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Negocio
{
   public class BL_Logic:Exception
    {

        

        public BL_Logic() : base("Punto4 Exception")
        {

            


        }

        public string Punto3Exception(Exception ex)
        {
            string Mensaje = "";

            Mensaje = Convert.ToString(ex.GetType())+". "+
                ex.Message;


            return Mensaje;

        }


    }
}
