using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EstudosCS.Ex0006
{
    class ContaBancaria
    {
        private double Saldo;

        public double GetSaldo()
        {
            return Saldo;
        }

        public void SetSaldo(double saldoParam)
        {
            Saldo = saldoParam;
        }


        }

    class MostrarDados
    {
        public static void Inicializar07()
        {
            var dinheiro = new ContaBancaria();

            dinheiro.SetSaldo(25.43);
            Console.WriteLine(dinheiro.GetSaldo());
        }
    }
}
