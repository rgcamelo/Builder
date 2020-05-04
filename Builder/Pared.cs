using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Pared : LugarDelMapa
    {
        public override void Entrar()
        {
            Console.WriteLine("Te haz Golpeado la Nariz");
        }
    }
}
