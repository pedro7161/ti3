using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    public delegate int namedlg(int a, int b);
    class biblio
    {
        
        public static int soma(int x, int y)
        {
            return x + y;
        }
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
        public void troca(ref int x,ref int y) {
            int pivo = x;
            x = y;
            y = pivo;
    
        }
        public static void somas(int a,int b, out int rslt,out float media)
        {
            rslt = a + b;
            media = (float)rslt / 2.0f;
        }
    }
}
