using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    abstract public class ClinicaVeterinaria
    {
        abstract public Animal crearAnimal(String tipo);
        abstract public Doctor crearDoctor(String tipo);
    }
}
