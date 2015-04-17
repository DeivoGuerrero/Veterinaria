using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    class ClinicaPerrosFabrica : ClinicaVeterinaria
    {
        public override Animal crearAnimal(string tipo)
        {
            Perro p = new Perro();
            p.setTipo(tipo);
            return p;
        }

        public override Doctor crearDoctor(string tipo)
        {
            DoctorPequeñosAnimales dpa = new DoctorPequeñosAnimales();
            dpa.setTipo(tipo);
            return dpa;
        }
    }
}
