using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegundoProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pressione a tecla A para alugar um filme ou S para sair da locadora:");
            char opcao = Console.ReadKey(true).KeyChar;
            if (opcao == 'A' || opcao == 'a')
            {
                Console.WriteLine("Pressione 1 para alugar Matrix");
                Console.WriteLine("Pressione 2 para alugar Home Aranha");
                Console.WriteLine("Pressione 3 para alugar Top Gun");
                int opcaoFilme = Convert.ToInt32(Console.ReadKey(true).KeyChar.ToString());

                switch(opcaoFilme)
                {
                    case 1:
                        Console.WriteLine("Você alugou Matrix");
                        break;
                    case 2:
                        Console.WriteLine("Você alugou Home Aranha");
                        break;
                    case 3:
                        Console.WriteLine("Você alugou Top Gun");
                        break;
                    default:
                        Console.WriteLine("Opção desconhecida");
                        break;
                }
            }
            else if (opcao == 'S' || opcao == 's')
            {
                Console.WriteLine("Muito obrigado. Volte Sempre!");
            }
            else
            {
                Console.WriteLine("Opção desconhecida");
            }
            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey();  
        }
    }
}
