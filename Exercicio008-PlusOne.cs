using System;

namespace EstudosCS.Exercicios
{
    public class Solution
    {
        public int[] PlusOne(int[] digits) // digits = [9,9,9,9] => [0,0,0,0] => [0,0,0,0,0] => [1,0,0,0,0]
        {
            for (int indice = digits.Length - 1; indice >= 0; indice--)
            {

                if (digits[indice] < 9)
                {
                    digits[indice] += 1;
                    return digits;
                }

                else
                {
                    digits[indice] = 0;
                }
            }

            int[] novoArray = new int[digits.Length + 1];

            novoArray[0] = 1;

            return novoArray;
        }

        public static void Inicializar008()
        {
            {
                int[] digits = { 9,9,9,9 };

                Solution solucao = new Solution();

                int[] resultado = solucao.PlusOne(digits);

                Console.WriteLine(string.Join(", ", resultado));
            }
        }
    }
}
