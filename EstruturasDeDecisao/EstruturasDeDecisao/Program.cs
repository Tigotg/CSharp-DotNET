using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturasDeDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if(se)... else(senao)...
            Console.WriteLine("Digite a sua idade: ");
            UInt32 Idade = Convert.ToUInt32(Console.ReadLine());

            if (Idade >= 18)
            {
                Console.WriteLine("Você é Maior de Idade!");
            }
            else
            {
                Console.WriteLine("Você é Menor de Idade!");
            }


            //if... else if...
            Console.WriteLine("Digite seu salário:");
            UInt32 Salario = Convert.ToUInt32(Console.ReadLine());
            if (Salario < 1000)
            {
                Console.WriteLine("Você ganha menos que 1 salário mínimo!");
            }
            else if (Salario < 2000)
            {
                Console.WriteLine("Você ganha menos que 2 salários mínimo");
            }
            else if (Salario < 5000)
            {
                Console.WriteLine("Você ganha menos que 5 salários mínimo");
            }
            else
            {
                Console.WriteLine("Você é rico!");
            }




            //Switch (Comutador)
            Console.WriteLine("Pressione uma tecla do seu teclado:");
            char tecla = Console.ReadKey(true).KeyChar;
            switch (tecla)
            {
                case 'a':
                    Console.WriteLine("Você Pressionou a");
                    break;
                case 'b':
                    Console.WriteLine("Você Pressionou b");
                    break;
                default:
                    Console.WriteLine("Eu não conheço essa tecla!");
                    break;
            }        
            Console.ReadKey();      

        }
    }
}
