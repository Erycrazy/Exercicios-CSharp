using System;
using System.Collections.Generic;
using System.Text;

namespace EstudosCS.Exercicios
{
    class Exercicio014_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;

            for (int i = 0; i < nums.Length; i++)
            {            
                if (val != nums[i])
                {
                    nums[k] = nums[i]; 
                    k++;
                }
            }
            return k;
        }
    }
}

