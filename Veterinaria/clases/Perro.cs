using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    class Perro : Animal
    {
        public override void caminar()
        {
           System.out.println ("El perro camina ");
        }

        public override void correr()
        {
            System.out.println ("El perro corre ");
        }

        public override void comer()
        {
            System.out.println ("El perro come ");
        }

        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
