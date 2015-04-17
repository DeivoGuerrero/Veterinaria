using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    class ClinicaCaballosFabrica : ClinicaVeterinaria
    {
        ClinicaCaballosFabrica crearAnimal();


        public override Animal crearAnimal(string tipo)
        {
            Caballo c = new Caballo();
            c.setTipo(tipo);
            return c;
        }

        public override Doctor crearDoctor(string tipo)
        {
            DoctorGrandesAnimales dga = new DoctorGrandesAnimales();
            dga.setTipo(tipo);
            return dga;
        }
    }
}
