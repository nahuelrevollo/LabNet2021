using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Automovil : Transporte
    {

        public Automovil(int CantidadPasajeros)
        {
            this.Pasajeros = CantidadPasajeros;
        }
        public override void Avanzar()
        {
            throw new NotImplementedException();
        }

        public override void Detenerse()
        {
            throw new NotImplementedException();
        }
    }
}
