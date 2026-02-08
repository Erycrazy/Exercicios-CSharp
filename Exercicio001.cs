using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EstudosCS.Ex0006
{
    class Exercicio001
    {
        public string PrimeiraPessoa(string nomeParam, int idadeParam)
        {
            string mensagem = $"O {nomeParam} tem {idadeParam} Anos";
            return mensagem;
        }
    }

    class Main01
    {
        public static void Inicializar01()
        {
            var pessoa01 = new Exercicio001();

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a idade: ");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine(pessoa01.PrimeiraPessoa(nome, idade));

        }
    }
}









