using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class biblio
    {
        public static int multiplica(int x, int fator = 2)
        {
            return x * fator;
        }
        public static int soman(params int[] nums)
        {
            int soma = 0;
            foreach (int pass in nums)
            {
                soma += pass;
            }
            return soma;
        }
        public static int somarr(int[] nums)
        {
            int soma = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                soma += nums[i];
            }
            return soma;
        }
    }
}
