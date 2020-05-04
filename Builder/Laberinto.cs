using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Laberinto
    {
        private List<Habitacion> Habitaciones;
        public Laberinto()
        {
            Habitaciones = new List<Habitacion>();
        }

        public Habitacion BuscarHabitacion(int numerohabitacion)
        {
            Habitacion habitacion = Habitaciones.Find(h => h._numeroHabitacion == numerohabitacion);
            return habitacion;
        }

        public void AñadirHabitacion(Habitacion habitacion)
        {
            Habitaciones.Add(habitacion);
        }
    }
}
