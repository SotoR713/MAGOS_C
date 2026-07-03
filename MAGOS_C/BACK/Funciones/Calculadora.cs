namespace MAGOS_C.BACK.Funciones
{
    internal class Calculadora
    {

        public static int RaizDigital(int numero)
        {
            while (numero >= 10)
            {
            int suma = 0;
                foreach (char i in numero.ToString())
                    suma += int.Parse(i.ToString());
                numero = suma;
            }
            return numero;
        }
    }
}
