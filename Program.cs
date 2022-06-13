using System;
using System.Globalization;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite quantos retângulos deseja: ");
            int quantidade = int.Parse(Console.ReadLine());//Pergunta e armazena a quantidade de retângulos que deseja

            Retangulo[] retangulos = new Retangulo[quantidade];//Declara e instancia o vetor

            for (int i = 0; i < quantidade; i++)//Inicia uma repetição conforme a quantidade de retângulos que colocou
            {
                Console.WriteLine("Informe a altura do retângulo: ");
                double Altura = double.Parse(Console.ReadLine());//Pergunta e armazena a altura do retângulo

                Console.WriteLine("Informe a largura do retângulo: ");
                double Largura = double.Parse(Console.ReadLine());//Pergunta e armazena a largura do retângulo

                retangulos[i] = new Retangulo(Altura, Largura);//Puxa os dados do override para exibir na tela

                Console.WriteLine(retangulos[i]);
            }
        }
    }
}