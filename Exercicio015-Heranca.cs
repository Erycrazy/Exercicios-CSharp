using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Exercicios { 

    public class Veiculo
    {
        public string Marca { get; protected set; }
        protected int Ano;
        protected double VelocidadeAtual;

        public Veiculo(string marcaParam, int anoParm, double velocidadeAtualParam)
        {
            Marca = marcaParam;
            Ano = anoParm;
            VelocidadeAtual = velocidadeAtualParam;
        }

        public virtual double Acelerar(double acelerarParam)
        {
            return  VelocidadeAtual += acelerarParam;
        }

    }

public class Carro : Veiculo
{
    public Carro(string marca, int ano, double velocidade) : base(marca, ano, velocidade)
    {

    }
    public override double Acelerar(double acelerarParam)
    {
        return VelocidadeAtual += acelerarParam * 1.2;
    }
}


    public class Bicicleta : Veiculo
    {
        public Bicicleta(string marca, int ano, double velocidade) : base(marca, ano, velocidade)
        {

        }

    
        public override double Acelerar(double acelerarParam)
        {
            return VelocidadeAtual += acelerarParam * 0.6;
        }
    }


    class Exercicio015_Heranca
    {
        public static void InicializarHeranca01()
        {
            List<Veiculo> listaVeiculos = new List<Veiculo>();

            listaVeiculos.Add(new Carro("Uno",1999, 5));
            listaVeiculos.Add(new Carro("Celta",1990, 5));
            listaVeiculos.Add(new Bicicleta("Calloi",2015, 5));
            listaVeiculos.Add(new Bicicleta("BMX",2022, 0));

            foreach(Veiculo veiculo in listaVeiculos)
            {
                Console.WriteLine($"Velocidade do {veiculo.Marca} é: {veiculo.Acelerar(10)}Km/h");
            }


        }
    }
}

