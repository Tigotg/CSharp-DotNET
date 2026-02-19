using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> ListaDeNomes = new List<string>();

            //Adicionar elementos
            ListaDeNomes.Add("Joana");
            ListaDeNomes.Add("Paulo");
            ListaDeNomes.Add("Marcia");
            ListaDeNomes.Add("Priscila");

            //Removendo elementos
            ListaDeNomes.Remove("Paulo");

            //Removendo elementos em posições específicas
            ListaDeNomes.RemoveAt(0);
            ListaDeNomes.RemoveAt(1);

            foreach (string nome in ListaDeNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("-----------------------");

            List<string> ListaDeNomes2 = new List<string>();

            ListaDeNomes2.Add("Joana");
            ListaDeNomes2.Add("Paulo");
            ListaDeNomes2.Add("Marcia");
            ListaDeNomes2.Add("Priscila");

            //Removendo uma faixa de elementos
            ListaDeNomes2.RemoveRange(1, 2);

            foreach (string nome in ListaDeNomes2)
            {
                Console.WriteLine(nome);
            }

            //Pegando o número de elementos
            Console.WriteLine("A lista ListaDeNomes2 possui: " + ListaDeNomes2.Count + " elementos");

            Console.WriteLine("-----------------------");

            //Concatenando listas
            List<string> ListaDeNomes3 = new List<string>();
            ListaDeNomes3.Add("Joana");
            ListaDeNomes3.Add("Paulo");
            ListaDeNomes3.Add("Marcia");
            ListaDeNomes3.Add("Priscila");
            List<string> ListaDeNomes4 = new List<string>();
            ListaDeNomes4.Add("José");
            ListaDeNomes4.Add("Bruna");
            ListaDeNomes4.Add("Evelin");
            ListaDeNomes4.Add("Pedro");

            List<string> ListaDeNomesConcatenada = ListaDeNomes3.Concat(ListaDeNomes4).ToList();

            foreach (string nome in ListaDeNomesConcatenada)
            {
                Console.WriteLine(nome);
            }

            //Verificando se a lista possui um determinado valor

            bool contemNome = ListaDeNomesConcatenada.Contains("Bruna");
            Console.WriteLine("A ListaDeNomesConcatenada contem o nome Bruna?");
            Console.WriteLine(contemNome);

            contemNome = ListaDeNomesConcatenada.Contains("Evelin");
            Console.WriteLine("A ListaDeNomesConcatenada contem o nome Evelin?");
            Console.WriteLine(contemNome);

            //Descobrindo o índice de um elemento
            int indice = ListaDeNomesConcatenada.IndexOf("Pedro");
            Console.WriteLine("O índice do nome Pedro é: " + indice);

            Console.WriteLine("-----------------------");

            //Operador where

            List<string> listaWhere = ListaDeNomesConcatenada.Where(x => x.StartsWith("M")).ToList();
            foreach (string nome in listaWhere)
            {
                Console.WriteLine(nome);
            }

            Console.ReadKey();
        }
    }
}
