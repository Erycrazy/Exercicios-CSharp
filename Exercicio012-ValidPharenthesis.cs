using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Exercicios
{
    class Exercicio012_ValidPharenthesis
    {
        public bool IsValid(string s)
        {
            var palavra = new Stack<char>();  
            var aberturaFechamento = new Dictionary<char, char>
            {
                {'(', ')'},
                {'[', ']'},
                {'{', '}'}
            };

            foreach (var caractere in s)
            {
                if (caractere == '(' || caractere == '[' || caractere == '{')
                {
                    palavra.Push(caractere);
                }


                else if (caractere == ')' || caractere == ']' || caractere == '}')
                {                                 
                    if (palavra.Count == 0)
                    {
                        return false;
                    }

                    else if (palavra.Peek() == '(' && caractere == ')')
                    {
                        palavra.Pop();
                    }

                    else if (palavra.Peek() == '[' && caractere == ']')
                    {
                        palavra.Pop();
                    }

                    else if (palavra.Peek() == '{' && caractere == '}')
                    {
                        palavra.Pop();
                    }

                    else
                    {
                        return false;
                    }
                }
            }        
            if (palavra.Count == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
