using System;
using System.Collections.Generic;
using System.Text;

namespace MAGOS_C.BACK.Funciones
{
    internal class Calculadora
    {

        public int raiz_digital(int numero)
        {
            while (numero >= 10)
            {
                int suma = 0;
                {
                    foreach (char i in numero.ToString())
                        suma += int.Parse(i.ToString());
                    numero = suma;
                    return numero;
                }
            }
        }
    }
}
