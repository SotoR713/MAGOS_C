namespace MAGOS_C.BACK.Servicios
{
    internal class Calculadora
    {
        //Raiz digital es una reduccion del numero ingresado a solo un digito, sumando todos los digitos hasta que quede uno
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
