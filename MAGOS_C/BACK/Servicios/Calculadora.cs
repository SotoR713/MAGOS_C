namespace MAGOS_C.BACK.Funciones
{
    internal class Calculadora
    {
        public static int RaizDigital(int numero)
        //Raiz digital es una reduccion del numero ingresado a solo un digito, sumando todos los digitos hasta que quede uno
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

    //internal class CrearElemento(int numeroDado)
    ////Crear un elemento asigna con el generador un numero aleatorio y tomando el ultimo digito le asigna un elemento de la lista de elementos
    //{

    //}
}
