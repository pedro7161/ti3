using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testes
{
    public class biblioteca
    {
        public static void salario(int sb){
            // 0-1000 taxa=5%  1000-1500=15%    1500-2000=23%  2000+ =30%
            double sl=0, t=0, d=0;
        if (sb>=0 && sb<=1000){
           sl=sb-(sb*0.05);
             t=0.05;
            d=sb*t;
           

        }
        else if(sb>1000 && sb<=1500){ sl=sb-(sb*0.15); t=0.15;
            d=sb*t;} 
        else if(sb>1500 && sb<=2000){ sl=sb-(sb*0.23); t=0.23;
            d=sb*t;} 
        else if(sb>2000){ sl=sb-(sb*0.3); t=0.3;
            d=sb*t;}

            Console.WriteLine("Salario bruto: ", sb, "Salario Liquido: ", sl, "desconto: ", d, "taxa: ", t);
            Console.ReadLine();
        }
        public static int menu()
        {
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.Write("1-selos 2-n primos 3-salariobruto 4-sair");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    opcao = -1;
                }
              
            } while (opcao < 1 || opcao > 4);
            return opcao;
        }
        public void dobros(int num,ref int res)
        {
            res=num * 2;
            
        }
        public static bool EPrimo(int num)
        {
            int div = 2, quoc, r;
            if (num < 2) return false;
            div = 2;
            do
            {
                r = num % div;
                quoc = num / div++;
            } while (r != 0 && quoc >= div);
           
            return num == 2 || r != 0;
        }
        public static int somares()
        {
            int counts = 0;
            Console.WriteLine("limite:");
            int limite = int.Parse(Console.ReadLine());
            for (int j = 1; j <= limite; j++)
            {
                Console.WriteLine("insira n para soma");
                int count = int.Parse(Console.ReadLine());
                counts = counts + count;
            }
            return counts;
        }
            public static void selos(int euros)
        {
            int quoc, resto, s5, s3;

            try
            {
                if(euros <= 8) {
                    quoc = euros / 8;
                    resto = euros % 8;
                    switch (resto) {
                        case 0:
                            s5 = quoc;
                            s3 = quoc;
                            break;
                        case 1:
                            s5 = quoc-1;
                            s3 = quoc+2;
                            break;
                        case 2:
                            s5 = quoc+1;
                            s3 = quoc-1;
                            break;
                        case 3:
                            s5 = quoc;
                            s3 = quoc+1;
                            break;
                        case 4:
                            s5 = quoc-1;
                            s3 = quoc+3;
                            break;
                        case 5:
                            s5 = quoc+1;
                            s3 = quoc;
                            break;
                        case 6:
                            s5 = quoc;
                            s3 = quoc+2;
                            break;
                        case 7:
                            s5 = quoc+2;
                            s3 = quoc-1;
                            break;
                      
                        default:
                            s5 = 0;
                            s3 = 0;
                            break;
                    }
                }
                else
                {
                    if (euros == 3)
                    {
                        s5 = 0;
                            s3 = 1;
                    }else if(euros == 5)
                    {
                        s5 = 1;
                        s3 = 0;
                    }
                    else if (euros == 6)
                    {
                        s3 = 2;
                        s5 = 0;
                    }
                    else
                    {
                        s5 = 0;s3 = 0;Console.WriteLine("quandia devolvida: ",euros);
                    }
                }
                Console.WriteLine("Selos 3: ",s3, "selos 5: ",s5);
            }
            
            catch (Exception erro)
            {

                Console.WriteLine(erro.Message);
            }
        }

        public static void doble(int d)
        { 
            Console.WriteLine("o dobro é :"+ (d * 2));
        }
        public static void checkpar(int x)
        {
            if (x%2 == 0)
            {
                Console.WriteLine(x+":par");
            }
            else
            {
                Console.WriteLine(x+":impar");
            }
        }
        public static void checksalbruto(float salario,float total,float salario_liquido)
        {
            
            if (salario < 1000)
            {
                salario_liquido = total = salario * 1 - 0.0f;
            }
            else if (salario >= 1500 && salario < 2000)
            {
                total=salario*0.15f;
                salario_liquido = total = salario * 1 - 0.15f;
            }
            else if (salario >= 2000)
            {
                total = salario * 0.30f;
                salario_liquido = total = salario * 1 - 0.30f;
            }

            Console.WriteLine("salario depois dos descontos:{0} salario liquido:{1}",total,salario_liquido);
        }
        public static void vendaselos(float dinheiro)
        {
            /*pretense criar uma maquina de venda de selos com as seguintes caratersticas:
            -sempre que for intruduzida uma quantia maior ou igual a 8 euros a maquina troca essa quantia por selos de 3 e 5 euros sem dar troco
            -sempre que for inferior a 8 devolve erro
            */
            int sel3=0;
            int sel5=0;
            Console.WriteLine(dinheiro);
            if (dinheiro >= 8f)
            {
                // selos = 3 e 5
                while (dinheiro > 0) { 
                if(dinheiro%3==0 && dinheiro % 5 != 0)
                {
                    dinheiro = dinheiro - 3;
                        sel3++;
                }
                else if(dinheiro % 5 == 0 && dinheiro % 3 != 0)
                {
                    dinheiro = dinheiro - 5;
                        sel5++;
                }
                }
                Console.WriteLine("selos3:" + sel3 + "selos5:" + sel5);
            }
            else
            {
                Console.WriteLine("erro");
            }
            

        }
    }
}
