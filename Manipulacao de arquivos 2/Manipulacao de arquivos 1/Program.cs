using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Manipulacao_de_arquivos_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string caminhoArquivo = @"C:\Users\tigot\Desktop\GitHub Tiago\PUBLICO\CSharp-DotNet\Manipulacao de arquivos\teste.txt";
            string caminhoArquivo2 = @"C:\Users\tigot\Desktop\GitHub Tiago\PUBLICO\CSharp-DotNet\Manipulacao de arquivos\teste2.txt";
            string texto1 = "João subiu no telhado. \r\n";
            string texto2 = "Luana, sua mãe, brigou com ele. \r\n";

            //Maneira não muito correta
            string conteudoInicial = File.ReadAllText(caminhoArquivo);
            string conteudoFinal = conteudoInicial + texto1 + texto2;
            File.WriteAllText(caminhoArquivo, conteudoFinal);

            //Maneira mais correta
            //File.AppendAllText(caminhoArquivo2, texto1);
            //File.AppendAllText(caminhoArquivo2, texto2);
            File.AppendAllText(caminhoArquivo2, texto1+texto2);
        }
    }
}
