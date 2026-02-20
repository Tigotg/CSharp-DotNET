using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulacao_de_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indexação
            string nome = "Paulo";
            char letra = nome[4];
            Console.WriteLine(letra);

            //Concatenar string
            string sobrenome = " dos Santos Silva";
            string nomecompleto = nome + sobrenome;
            Console.WriteLine(nomecompleto);

            string nomecompleto2 = String.Concat(nome, sobrenome);
            Console.WriteLine(nomecompleto2);

            //Substituição de strings
            string endereco = "Rua das Tulipas Brancas";
            endereco = endereco.Replace("Brancas", "Vermelhas");
            Console.WriteLine(endereco);

            //Remoção de strings
            string endereco2 = "Rua das Tulipas Vermelhas";
            endereco2 = endereco2.Replace(" Vermelhas", "");
            Console.WriteLine(endereco2);

            string endereco3 = "Rua das Tulipas Vermelhas";
            endereco3 = endereco3.Remove(0, 4);
            Console.WriteLine(endereco3);

            //Capitalização de strings
            string nome2 = "Paulos dos Santos";
            nome2 = nome2.ToUpper();
            Console.WriteLine(nome2);
            nome2 = nome2.ToLower();
            Console.WriteLine(nome2);

            //Contém
            string nome3 = "Paulos dos Santos";
            bool contem = nome3.Contains("Paulo");
            Console.WriteLine(contem);
            contem = nome3.Contains("Marcio");
            Console.WriteLine(contem);

            //Localização de textos
            string nome4 = "Paulos dos Santos";
            int indice = nome4.IndexOf("dos");
            Console.WriteLine(indice);

            //Divisão de strings
            string nome5 = "Paulos dos Santos";
            string[] divisores = {"dos"};
            string[] resultadoDaDivisao = nome5.Split(divisores, StringSplitOptions.None);
            foreach(string texto in resultadoDaDivisao)
            {
                Console.WriteLine(texto);
            }

            //Número de caracteres
            string nome6 = "Paulos dos Santos";
            int numerocaracteres = nome6.Length;
            Console.WriteLine(numerocaracteres);

            //Substring
            string nome7 = "Paulos dos Santos";
            string ultimoNome = nome7.Substring(8, 5);
            Console.WriteLine(ultimoNome);

            //Formatação composta
            string nome8 = "Pedro {0} {1}";
            Console.WriteLine(nome8, "da Silva", "Santos");
            string nomeCompleto6 = String.Format(nome8, "da Silva", "Santos");
            Console.WriteLine(nomeCompleto6);

            Console.ReadKey();
        }
    }
}