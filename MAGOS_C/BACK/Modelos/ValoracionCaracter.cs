namespace MAGOS_C.BACK.Clases
{
    internal class ValoracionCaracter
    {
        public string Letra { get; set}
        public int Valor { get; set; }

        public ValoracionCaracter(string letra, int valor)
        {
            Letra = letra;
            Valor = valor;
        }

    }
}
