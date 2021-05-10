using System;

namespace Exercício_4___Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            int proximonumero = 1;
            int numeroanterior = -1;
            int resultado;

            do
            {
                resultado = numeroanterior + proximonumero;
                numeroanterior = proximonumero;
                proximonumero = resultado;

                Console.Write(resultado + ", ");

            } while (resultado < 500);
        }
    }
}
