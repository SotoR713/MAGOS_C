using MAGOS_C.BACK.Servicios;
using MAGOS_C.BACK.Modelos;


Console.WriteLine($"La raíz digital de 95058 es: {Calculadora.RaizDigital(95058)}");
Console.WriteLine($"La raíz digital de 5 es: {Calculadora.RaizDigital(5)}");
Console.WriteLine($"La raíz digital de 95 es: {Calculadora.RaizDigital(95)}");
Console.WriteLine($"La raíz digital de 508 es: {Calculadora.RaizDigital(508)}");
Console.WriteLine($"La raíz digital de 11111 es: {Calculadora.RaizDigital(11111)}");

var calcular = new  Generador(95058);
for (int i = 1; i <= 15; i++)
{
    Console.WriteLine($"Aleatorio() #{i}: {calcular.Aleatorio()}");
    
}
