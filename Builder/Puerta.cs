using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Puerta : LugarDelMapa
    {
        private Habitacion _habitacion1;
        private Habitacion _habitacion2;
        bool EstaAbierta = true;

        public Puerta(Habitacion h1, Habitacion h2)
        {
            _habitacion1 = h1;
            _habitacion2 = h2;
        }

        public Habitacion OtroLadoDe()
        {
            return _habitacion2;
        }
        public override void Entrar()
        {
            if (EstaAbierta)
            {
                Console.WriteLine("Pasando La Puerta");
                OtroLadoDe().Entrar();
            }
        }
    }
}
