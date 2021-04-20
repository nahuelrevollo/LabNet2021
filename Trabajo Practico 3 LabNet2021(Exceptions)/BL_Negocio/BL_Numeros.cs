using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace BL_Negocio
{
    public class BL_Numeros

    {

		//CONSTRUCTOR
		public BL_Numeros ()
		{

		}

        public string Dividir_X_Cero(int Numero)
        {
			string M_Respuesta="";
			int Resultado_Division;
			int DivisorCero = 0;

			try
			{
				Resultado_Division = Numero / DivisorCero;
				M_Respuesta = "Division exitosa, el resultado es: " + Resultado_Division;

			}
			catch (DivideByZeroException )
			{

				DivideByZeroException Mensaje = new DivideByZeroException("Recuerda que no se puede dividir por 0");

				throw Mensaje;

				

			}
		
				
			return M_Respuesta;
			
        }

		public int DividirNumeros(int Numero1, int Numero2)
		{
			int ResultadoDivision;

			try
			{

				ResultadoDivision = Numero1 / Numero2;

			}
			catch (DivideByZeroException)
			{

				DivideByZeroException Mensaje = new DivideByZeroException("Solo Chuck Norris divide por cero!");


				throw Mensaje;
			}
		
			
			

			return ResultadoDivision;

		}

    }
}
