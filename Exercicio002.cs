using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Ex0006
{
    class Produto01
    {
        public string nome;
        public double preco;
        public int quantidadeEstoque;

        public void inserir()
        { 
            Console.Write("Digite o nome do Produto: ");
            this.nome = Console.ReadLine();

            Console.Write("Digote o Preço do produto: ");
            double.TryParse(Console.ReadLine(), out this.preco);

            Console.Write("Digite a quantidade desse produto: ");
            int.TryParse(Console.ReadLine(), out this.quantidadeEstoque); 


        }

        public static void Inicializar02()
        {
           Produto01 produto = new Produto01();

            produto.inserir();
            string mensagem = $"O Produto é {produto.nome}, o Preço é {produto.preco}, e tem {produto.quantidadeEstoque} no Estoque";
            Console.WriteLine(mensagem);
        }
    }
}
