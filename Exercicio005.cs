using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Ex0006
{
    class Produto02
    {
        public string nomeProduto;
        public double precoProduto;
        public int estoqueInicialProduto;

        public Produto02(string nomeParam, double precoParam, int quantidadeEstoqueParam)
        {
            this.nomeProduto = nomeParam;
            this.precoProduto = precoParam;
            this.estoqueInicialProduto = quantidadeEstoqueParam;
        }
    }


    class ChamandoProduto
    {
        public static void Inicializar05()
        {
            var produto01 = new Produto02(nomeParam: "Banana", precoParam:  24.67, quantidadeEstoqueParam: 137);

            Console.WriteLine($"{produto01.nomeProduto}, {produto01.precoProduto}, {produto01.estoqueInicialProduto}");

            var produto02 = new Produto02(nomeParam: "Abacaxi", precoParam:39.99, quantidadeEstoqueParam: 98);

            Console.WriteLine($"{produto02.nomeProduto}, {produto02.precoProduto}, {produto02.estoqueInicialProduto}");

            produto02.precoProduto = 27.99;

            Console.WriteLine(produto02.precoProduto);
        }
    }
}


