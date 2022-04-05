using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testes
{
    class Program
    {
        static void Main(string[] args)
        {
            biblioteca.doble(5);

            Random r = new Random();
            for(int i = 0; i < 100; i++) { 
            int x = r.Next(0, 100);
                biblioteca.checkpar(x);
            }

            try
            {
                float total=0;
                float salario_liquido=0;
                Console.WriteLine("insert salario brut");
                float salario=float.Parse(Console.ReadLine());
                biblioteca.checksalbruto(salario,total,salario_liquido);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
            }
            //try
            //{
            //    Console.WriteLine("insert selos");
            //    float dinheiro = float.Parse(Console.ReadLine());
            //    biblioteca.vendaselos(dinheiro);

            //}
            //catch (Exception erro)
            //{
            //    Console.WriteLine(erro);
            //}
            try
            {
                Console.WriteLine("insert selos");
                int dinheiro = int.Parse(Console.ReadLine());
                biblioteca.selos(dinheiro);

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
            }
       
             
                Console.WriteLine(biblioteca.somares());

            
            for(int i = 1; i < 100; i++)
            {
                Console.WriteLine(biblioteca.EPrimo(i));
                if (biblioteca.EPrimo(i))
                {
                    Console.Write("{0}-", i);
                }
                else
                {
                    Console.Write("{0}-", i);
                }
            }
            int y = 0;
            biblioteca a = new biblioteca();
            a.dobros(3,ref y);

            //for (; ; )
            //{
            //    int opcao;
            //    try
            //    {
            //        opcao = biblioteca.menu();
            //        switch (opcao)
            //        {
            //            case 1:
            //                Console.WriteLine("quantia");
            //                biblioteca.selos(int.Parse(Console.ReadLine()));
            //                break;
            //            case 2:
            //                Console.WriteLine("quantia");
            //                biblioteca.EPrimo(int.Parse(Console.ReadLine()));
            //                break;
            //            case 3:
            //                Console.WriteLine("sair do programa");
            //                Console.Read();
            //                return;
            //        }

            //    }
            //    catch (Exception erro)
            //    {
            //        Console.WriteLine(erro.Message);

            //    }
            //    finally
            //    {
            //        Console.ReadLine();
            //    }


           
                int opcao;
                for (; ; )
                {
                    try
                    {
                        opcao = biblioteca.menu();
                        switch (opcao)
                        {
                            case 1:
                                //selos
                                Console.Write("Introduza quantia para selos:");
                                int quantia = int.Parse(Console.ReadLine());
                                biblioteca.selos(quantia);
                                Console.ReadLine();
                                break;
                            case 2:
                                //primos
                                Console.Write("Introduza limite de primos:");
                                int limite = int.Parse(Console.ReadLine());
                                for (int c = 0, num = 2; c < limite; num++)
                                {
                                    if (biblioteca.EPrimo(num))
                                    {
                                        Console.Write("{0}-", num);
                                        c++;
                                    }
                                }
                                Console.ReadLine();
                                break;
                            case 3:
                              //chamar no main uma funçao public static void chama-se salario, recebe o int salariobruto
                    //devolver o salario bruto, a taxa e  (desconto=salariobruto*taxa) e o salario liquido
                    //0-1000 taxa=5%  1000-1500=15%    1500-2000=23%  2000+ =30%
                            Console.Write("Introduza salario bruto");
                            //    int sb=int.Parse(Console.ReadLine());
                            biblioteca.salario(int.Parse(Console.ReadLine()));
                            break;
                            case 4:
                                Console.WriteLine("Sair do Programa");
                                Console.ReadLine();
                                return;

                        }
                    }
                    catch (Exception erro)
                    {
                        Console.WriteLine(erro.Message);

                    }
                    finally
                    {

                    }
                  

                }

            
        
        

        }
        
    }
}
