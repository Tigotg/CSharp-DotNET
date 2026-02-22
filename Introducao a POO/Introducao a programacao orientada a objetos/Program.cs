using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Introducao_a_programacao_orientada_a_objetos
{ 
    public class Carro
    {
        //Atributos ou variáveis
        private string marca;
        private string modelo;
        private UInt32 velocidade;
        private bool carroLigado;

        //propriedades
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public UInt32 Velocidade
        {
            get { return velocidade; }
            set { velocidade = value; }
        }
        public bool CarroLigado
        {
            get { return carroLigado; }
            set { carroLigado = value; }
        }

        //métodos
        public void LigarCarro()
        {
            carroLigado = true;
            Console.WriteLine("Ligando o carro da marca " + marca + " e do modelo " + modelo);
        }
        public void DesligarCarro()
        {
            carroLigado = false;
            Console.WriteLine("Desligando o carro da marca " + marca + " e do modelo " + modelo);
        }
        public void AcelerarCarro(UInt32 velocidadeFinal)
        {
            if(carroLigado == true)
            {
                velocidade = velocidadeFinal;
                Console.WriteLine("A velocidade do carro da marca " + marca + " e do modelo " + modelo + " é " + velocidade);
            }
            else
            {
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " esta desligado ");
            }
        }
        public void PararCarro()
        {
            if(velocidade == 0)
            {
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " já esta parado ");
            }
            else
            {
                velocidade = 0;
                Console.WriteLine("O carro da marca " + marca + " e do modelo " + modelo + " esta parado ");
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro hondaFit = new Carro();
            hondaFit.Marca = "Honda";
            hondaFit.Modelo = "FIT";
            hondaFit.LigarCarro();
            hondaFit.AcelerarCarro(80);
            hondaFit.PararCarro();
            hondaFit.DesligarCarro();

            Carro fiatUno = new Carro();
            fiatUno.Marca = "Fiat";
            fiatUno.Modelo = "Uno";
            fiatUno.AcelerarCarro(80);
            fiatUno.LigarCarro();
            fiatUno.AcelerarCarro(80);
            fiatUno.PararCarro();
            fiatUno.DesligarCarro();

            Console.ReadKey();
        }
    }
}
