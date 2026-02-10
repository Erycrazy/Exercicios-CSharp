using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Ex0006
{
    class Exercicio003
    {
        public string apresentar(string nomeParam, int idadeParam)
        {
            string mensagem = $"Olá meu nome é {nomeParam}, e eu tenho {idadeParam}";

            return mensagem;
        }

        public static void Inicializar03()
        {
            var apresentando = new Exercicio003();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int.TryParse(Console.ReadLine(), out int idade);

            Console.WriteLine(apresentando.apresentar(nome, idade));
        }
    }
}
