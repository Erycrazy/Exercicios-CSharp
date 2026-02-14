using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Ex0006
{
    class Moto
    {
        private string Marca;
        private string Modelo;
        private int Cilindrada; //Colocar "uint", que não permite sinal, assim não dando valores negativos

        public Moto(string marca, string modelo, int cilindrada)
        {
            //Marca = marca;
            //Modelo = modelo;              //Sem verificação
            //Cilindrada = cilindrada;

            SetMarca(marca);
            SetModelo(modelo);              //Com verificação
            SetCilindrada(cilindrada);
        }

        public Moto()
        {

        }

        public string GetMarca()
        {
            return Marca;
        }

        public void SetMarca(string marca)
        {
            Marca = marca;
        }

        public string GetModelo()
        {
            return Modelo;
        }

        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public int GetCilindrada()
        {
            return Cilindrada;
        }

        public void SetCilindrada(int cilindrada)
        {
            //if (Cilindrada < 0)
            //{                                         //1° Opção
            //    Cilindrada = cilindrada;
            //}

            //Cilindrada = Math.Abs(cilindrada);       // 2° Opção

        }
        class GetSet
        {
            public static void Inicializar()
            {
                var moto01 = new Moto("Kawasaki", "Ninja", 700);

                Console.WriteLine(moto01.GetMarca());
                Console.WriteLine(moto01.GetModelo());
                Console.WriteLine(moto01.GetCilindrada());

                var moto02 = new Moto();

                moto02.SetMarca("Honda");
                moto02.SetModelo("Fit");
                moto02.SetCilindrada(-234);





            }
        }
    }
}
