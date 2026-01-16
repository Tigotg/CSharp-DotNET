using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadoreLogicosEntreVariaveisNumericas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Negação Representado por: ~ 
            int var1 = 0b11001100;
            int resultadoNegacao = ~var1;
            Console.WriteLine("O resultado da negação de " + Convert.ToString(var1, 2) + " é : " + Convert.ToString(resultadoNegacao, 2));


            //Operador OU (OR) Representado por: |
            int var2 = 0b11001100;
            int var3 = 0b11110000;
            int resultadoOU = var2 | var3;
            //Nesse caso a operação ocorrer Bite a Bite
            Console.WriteLine("O resultado da operação OU entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoOU, 2));


            //Operador E (AND) Representado por: &
            int resultadoE = var2 & var3;
            //Nesse caso a operação ocorrer Bite a Bite
            Console.WriteLine("O resultado da operação E entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoE, 2));


            //Operador OU EXCLUSIVO (XOR) Representado por ^
            int resultadoXOR = var2 ^ var3;
            //Nesse caso a operação ocorrer Bite a Bite
            Console.WriteLine("O resultado da operação XOR entre " + Convert.ToString(var2, 2) + " e " + Convert.ToString(var3, 2) + " é: " + Convert.ToString(resultadoXOR, 2));


            //Operador > e <
            int var4 = 10;
            int var5 = 20;
            Console.WriteLine("O valor " + var4 + " é maior (>) que " + var5 + "? " + (var4 > var5));
            Console.WriteLine("O valor " + var4 + " é menor (<) que " + var5 + "? " + (var4 < var5));

            //Operador >= e <=
            Console.WriteLine("O valor " + var4 + " é maior ou igual a (>=) que " + var5 + "? " + (var4 >= var5));
            Console.WriteLine("O valor " + var4 + " é menor ou igual a (<=) que " + var5 + "? " + (var4 <= var5));
            Console.WriteLine("O valor " + var4 + " é maior ou igual a (>=) que " + var4 + "? " + (var4 >= var4));
            Console.WriteLine("O valor " + var5 + " é menor ou igual a (<=) que " + var5 + "? " + (var5 <= var5));


            //Operador Igual Representador por: ==
            bool resultadoIgual = (var4 == var4);
            Console.WriteLine("O valor " + var4 + " é igual (==) a " + var4 + "? " + resultadoIgual);
            Console.WriteLine("O valor " + var4 + " é igual (==) a " + var5 + "? " + (var4 == var5));

            //Mais sobre operadores
            bool var6 = true;
            bool var7 = false;
            bool resultadoOU_1 = var6 | var7;
            bool resultadoOU_2 = var6 || var7; //Com dois || é mais rápido

            bool resultadoE_1 = var6 & var7;
            bool resultadoE_2 = var6 && var7; //Com dois && é mais rápido

            Console.ReadKey();
        }
    }
}
