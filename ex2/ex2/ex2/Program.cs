using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {


            int resul = biblio.multiplica(5, 4);
            Console.WriteLine(resul);
            Console.WriteLine(biblio.multiplica(7));
            biblio ola = new biblio();
            int x = 1, y = 2;
            Console.WriteLine("x={0} y={1}",x,y);
            ola.troca(ref x, ref y);
            Console.WriteLine("x={0} y={1}", x, y);
            int res;
            float med;
            biblio.somas(x,y,out res,out med);
            //namedlg func = biblio.soma;
            namedlg func = new namedlg(biblio.soma);
            Console.WriteLine(func(2,3));
            func = delegate (int a, int b) { return a * b; };
            Console.WriteLine(func(2, 3));
            func = (a, b) => a - b;
            Console.WriteLine(func(2, 3));

            Console.ReadLine();
        }
    }
}
