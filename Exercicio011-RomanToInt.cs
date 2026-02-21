using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Exercicios
{
    class Exercicio011_RomanToInt
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> mapeamento = new Dictionary<char, int>
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
            };

            int valorAtual = 0;
            int valorProximo = 0;
            int resultado = 0;

            for (int indice = 0; indice < s.Length - 1; indice++)
            {
                valorAtual = mapeamento[s[indice - 1]];

                if (indice + 1 < s.Length)
                {
                    valorProximo = mapeamento[s[indice + 1]];
                }

                if (valorAtual < valorProximo)
                {

                    resultado -= valorAtual;
                }

                else
                {
                    resultado += valorAtual;
                }


            }
            return resultado;
        }
    }
}

