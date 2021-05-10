using System;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nome;
            string Senha;
            int número;
            do
            {
                Console.WriteLine("Nome de usuário: ");
                Nome = Console.ReadLine() ;
                Console.WriteLine("Senha: ");
                Senha = Console.ReadLine();
                if (Nome == Senha)
                {
                    Console.WriteLine("Nome de usuário e Senha coincidem, favor digite outro Nome de usuário ou uma nova senha");
                    número = 1;
                } else
                {
                    Console.WriteLine("Dados registrados no Sistema, o contato será feito em breve");
                    número = 0;
                }
            } while (número == 1);
        }
    }
}
