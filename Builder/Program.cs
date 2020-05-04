using System;
using System.Collections.Generic;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Laberinto laberinto;
            JuegoDelLaberinto juegoDelLaberinto = new JuegoDelLaberinto();
            ConstructorLaberintoenEle constructor = new ConstructorLaberintoenEle();

            laberinto = juegoDelLaberinto.CrearLaberinto(constructor);
        }
    }


    

    

    


    


}
