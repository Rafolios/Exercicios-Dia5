using System;

namespace Exercício_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta;
            bool validade;
            do{
                Console.WriteLine("Qual a sua nota?");
                resposta = int.Parse(Console.ReadLine());
                if (resposta < 0 || resposta > 10) {
                    validade = false;
                    Console.WriteLine("o numero digitado é inválido, repita o processo e tente denovo!");
                } else {
                    Console.WriteLine("sua nota foi registrada no sistema, aguarde o boletim para resultados!!");
                    validade = true;
                }
            } while(validade == false);
        }
    }
}
