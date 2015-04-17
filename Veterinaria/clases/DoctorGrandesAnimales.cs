using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    class DoctorGrandesAnimales : Doctor
    {
        public override void diagnosticarAnimal()
        {
           System.out.println(" Diagnostica grandes animales");
        }

        public override void curarAnimal()
        {
           System.out.println(" Cura grandes animales");
        }

        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
