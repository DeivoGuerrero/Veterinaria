using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria.clases
{
    class Caballo : Animal
    {

        public  void caminar()
        {
            System.out.println ("El caballo camina ");
        }

        public override void correr()
        {
            System.out.println ("El caballo corre ");
        }

        public override void comer()
        {
            System.out.println ("El caballo come");
        }

        string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
