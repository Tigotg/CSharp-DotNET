using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoresLogicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Var1 = true;
            bool Var2 = false;

            //Negação representado por: !
            bool ResultadoNegacao = !Var1;
            Console.WriteLine("A negação de: " + Var1 + " é " + ResultadoNegacao);

            ResultadoNegacao = !Var2;
            Console.WriteLine("A negação de: " + Var2 + " é " + ResultadoNegacao);
            Console.WriteLine(" ");


            //Operador E (AND) representado por: &
            bool ResultadoE = Var1 & Var1;
            Console.WriteLine("O resultado da operação E entre " + Var1 + " e " + Var1 + " resulta em: " + ResultadoE);

            ResultadoE = Var1 & Var2;
            Console.WriteLine("O resultado da operação E entre " + Var1 + " e " + Var2 + " resulta em: " + ResultadoE);

            ResultadoE = Var2 & Var2;
            Console.WriteLine("O resultado da operação E entre " + Var2 + " e " + Var2 + " resulta em: " + ResultadoE);
            Console.WriteLine(" ");


            //Operador OU (OR) representado por: |
            bool ResultadoOU = Var1 | Var1;
            Console.WriteLine("O resultado da operação OU entre " + Var1 + " e " + Var1 + " resulta em: " + ResultadoOU);

            ResultadoE = Var1 | Var2;
            Console.WriteLine("O resultado da operação OU entre " + Var1 + " e " + Var2 + " resulta em: " + ResultadoOU);

            ResultadoE = Var2 | Var2;
            Console.WriteLine("O resultado da operação OU entre " + Var2 + " e " + Var2 + " resulta em: " + ResultadoOU);
            Console.WriteLine(" ");


            //Operador OU EXCLUSIVO (XOR) representado por: ^
            bool ResultadoXOR = Var1 ^ Var1;
            Console.WriteLine("O resultado da operação XOR entre " + Var1 + " e " + Var1 + " resulta em: " + ResultadoXOR);

            ResultadoXOR = Var1 ^ Var2;
            Console.WriteLine("O resultado da operação XOR entre " + Var1 + " e " + Var2 + " resulta em: " + ResultadoXOR);

            ResultadoXOR = Var2 ^ Var2;
            Console.WriteLine("O resultado da operação XOR entre " + Var2 + " e " + Var2 + " resulta em: " + ResultadoXOR);

            Console.ReadKey();
        }
    }
}
