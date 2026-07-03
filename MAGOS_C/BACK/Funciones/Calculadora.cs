using System;
using System.Collections.Generic;
using System.Text;

namespace MAGOS_C.BACK.Funciones
{
    internal class Calculadora
    {

        public static int RaizDigital(int numero)
        {
            int suma = 0;
            while (numero >= 10)
            {
                foreach (char i in numero.ToString())
                    suma += int.Parse(i.ToString());
                numero = suma;
            }
            return numero;
        }
    }
}
