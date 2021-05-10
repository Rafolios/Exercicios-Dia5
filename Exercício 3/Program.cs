using System;

namespace Exercício_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Olá " + nome + " qual é a sua idade?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu salário?");
            int salario = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o seu estado civil? definir como s=Solteiro c=Casado v=Viúvo d=divorciado");
            string estadocivil = Console.ReadLine();

            if (nome != null)
            {
                Console.WriteLine("o nome" + nome + " foi cadastrado  no sistema");
            } else{Console.WriteLine("ERRO! Favor cadastrar um nome válido.");}

            if (idade > 0 || idade < 150)
            {
                Console.WriteLine("idade: " + idade + " anos cadastrada no sistema");
            } else{Console.WriteLine("ERRO! Favor cadastrar uma idade entre 0 e 150 anos.");}

            if (salario > 0)
            {
                  Console.WriteLine("salário " + salario + " reais cadastrado no sistema");
            } else{Console.WriteLine("ERRO! Favor cadastrar um salário maior que 0 reais");}

            if (estadocivil == "s" || estadocivil == "c" || estadocivil == "v" || estadocivil == "d")
            {
                Console.WriteLine("Estado civil cadastrado no sistema");
            }else{Console.WriteLine("ERRO! Estado civil s´pode ser cadastrado como s=Solteiro c=Casado v=Viúvo d=divorciado");}
        }
    }
}
