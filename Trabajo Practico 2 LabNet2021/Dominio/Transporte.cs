using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public abstract class  Transporte


    {
        


        public int Pasajeros { get; set; }

        public abstract void Avanzar();


        public abstract void Detenerse();


    }
}
