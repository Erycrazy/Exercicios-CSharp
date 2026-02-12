using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Ex0006
{
    class Exercicio004
    {
        int quantidadeNoEstoque = 0;
        public int adicionarEstoque(int quantidadeAdicionarParam)
        {
            this.quantidadeNoEstoque += quantidadeAdicionarParam;
            return this.quantidadeNoEstoque;
            
        }

        public int removerEstoque(int quantidadeRemover)
        {
            if (this.quantidadeNoEstoque >= quantidadeRemover)
            {
                quantidadeNoEstoque -= quantidadeRemover;
                return quantidadeNoEstoque;
                
            }

            return this.quantidadeNoEstoque;
        }
        public void mostrarQntEstoque()
        {
            Console.WriteLine($"A quantidade no estoque é de {this.quantidadeNoEstoque}");
        }

        public static void Inicializar04()
        {
            var estoque = new Exercicio004();

            estoque.adicionarEstoque(100);
            estoque.mostrarQntEstoque();
            estoque.removerEstoque(10);
            estoque.mostrarQntEstoque();
            estoque.removerEstoque(100);
            estoque.mostrarQntEstoque();

            estoque.adicionarEstoque(27);
            estoque.mostrarQntEstoque();

        }
    }
}
