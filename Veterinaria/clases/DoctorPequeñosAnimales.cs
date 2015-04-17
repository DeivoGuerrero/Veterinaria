using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    class DoctorPequeñosAnimales : Doctor
    {
        public override void diagnosticarAnimal()
        {
            System.out.println(" Diagnostica pequeños animales");
        }

        public override void curarAnimal()
        {
           System.out.println(" Cura pequeños animales");
        }

        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
