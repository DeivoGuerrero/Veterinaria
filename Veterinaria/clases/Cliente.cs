using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    public static void main (String ... arg)
    {
         ClinicaPerrosFabrica cpf = new ClinicaPerrosFabrica() ;
		 Perro p =  (Perro)cpf.crearAnimal("danes");
		 System.out.println(p.getTipo());
    }
}
