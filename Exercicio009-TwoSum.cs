using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Exercicios
{
    public class Solution02 // [1, 5, 0, 0, 0, 0, 0, 0, 0, 0, 3, 7]
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var guardarIndice = new Dictionary<int, int>(); //Cria um dicionario, assim consegue o O(N)

            for (int indice = 0; indice < nums.Length; indice++)  //For que vai até o final do array
            {

                int valorSobrado = target - nums[indice]; //Aqui tira o valor do target do valor do array,
                                                          //para poder saber se o valor já tem ou não

                if (guardarIndice.ContainsKey(valorSobrado)) //Aqui vê se já tem o valor, se já tem,
                                                             //pronto, foi encontrado
                {
                    return new int[] { guardarIndice[valorSobrado], indice };
                }

                if (!guardarIndice.ContainsKey((int)nums[indice]))  //Se ele NÃO tem o valor, adiciona
                {
                    guardarIndice.Add(nums[indice], indice);
                }

            }

            return null;

        }
        public static void InicializarTwoSum()
        {
            int[] a = {21, 54, 32, 65, 32, 45, 21, 43, 87};
            int t = 152;
            
            Solution02 solucao = new Solution02();

            int[] resultado = solucao.TwoSum(a, t);

            Console.WriteLine(string.Join(", ", resultado));


        }
    }
}