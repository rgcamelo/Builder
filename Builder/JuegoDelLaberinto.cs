using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class JuegoDelLaberinto
    {
        public JuegoDelLaberinto()
        {

        }

        public Laberinto CrearLaberinto()
        {
            Laberinto laberinto = new Laberinto();

            Habitacion h1 = new Habitacion(1);
            Habitacion h2 = new Habitacion(2);

            laberinto.AñadirHabitacion(h1);
            laberinto.AñadirHabitacion(h2);

            Puerta puerta = new Puerta(h1, h2);

            h1.EstablecerLado((Direccion)0, new Pared());
            h1.EstablecerLado((Direccion)1, puerta);
            h1.EstablecerLado((Direccion)2, new Pared());
            h1.EstablecerLado((Direccion)3, new Pared());

            h2.EstablecerLado((Direccion)0, new Pared());
            h2.EstablecerLado((Direccion)1, new Pared());
            h2.EstablecerLado((Direccion)2, new Pared());
            h2.EstablecerLado((Direccion)3, puerta);

            return laberinto;
        }

        public Laberinto CrearLaberinto(ConstructorLaberinto constructor)
        {
            constructor.ConstruirLaberinto();
            Laberinto laberinto = constructor.ObtenerLaberinto();

            return laberinto;
        }
    }
}
