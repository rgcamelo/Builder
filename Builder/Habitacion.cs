using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Habitacion : LugarDelMapa
    {
        public int _numeroHabitacion;
        private LugarDelMapa[] lados = new LugarDelMapa[4];

        public Habitacion(int numhabitacion)
        {
            _numeroHabitacion = numhabitacion;
        }

        public void EstablecerLado(Direccion direccion, LugarDelMapa lugar)
        {
            int lado = (int)direccion;
            lados[lado] = lugar;
        }

        public LugarDelMapa ObtenerLado(Direccion direccion)
        {
            int lado = (int)direccion;
            lados[lado].Entrar();
            return lados[lado];
        }
        public override void Entrar()
        {
            Console.WriteLine($" Habitacion :{_numeroHabitacion}");
        }
    }
}
