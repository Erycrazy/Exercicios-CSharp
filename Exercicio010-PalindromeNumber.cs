using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Exercicios
{
    public class Solution03
    {
        public class Solution
        {
            public bool IsPalindrome(int x)
            {
                int invertido = 0;

                if (x < 0)
                {
                    return false;
                }

                if (x == 0)
                {
                    return true;
                }

                if (x % 10 == 0)
                {
                    return false;
                }

                if (x < 10 && x > 0)
                {
                    return true;
                }
                
                while (invertido < x)
                {
                    invertido = invertido * 10 + (x % 10);
                    x /= 10;             
                }

                if (x == invertido)
                {
                    return true;
                }
                if (x == invertido / 10)
                {
                    return true;
                }              
                return false;
            }

            public static void InicializarPalindromo()
            {
                int x = 323323323;

                Solution solucao = new Solution();

                bool resultado = solucao.IsPalindrome(x);

                Console.WriteLine(string.Join(", ", resultado));

                
            }
        }
    }
}

