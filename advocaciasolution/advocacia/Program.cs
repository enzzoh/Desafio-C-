using System;

namespace advocacia
{
    class Program
    {
        static void Main(string[] args)
        {

            
            
                Console.WriteLine("Deseja iniciar?");
                string b = Convert.ToString(Console.ReadLine());
                while (b == "sim")
                {

                    Console.WriteLine("Qual seu nome?");
                    string a = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Então seu nome é: {0}", a);
                    Console.Clear();
                    Console.WriteLine("pressione enter para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine("Deseja continuar? digite sim");
                    b = Convert.ToString(Console.ReadLine());


                }

            
        

      

           


        }
    }
}
