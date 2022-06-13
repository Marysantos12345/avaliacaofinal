using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio1
{
    class Retangulo
    {
        //Declaração das variaveis onde são guardados as informações.
        public double Altura { get; set; }
        public double Largura { get; set; }
        public Retangulo(double altura, double largura)
        {
            Altura = altura;
            Largura = largura;
        }
        public double CalcularArea()
        {
            return Altura * Largura; //Uma função que faz a conta para caucular a area.
        }
        public double CalcularPer()//Uma função que faz a conta do perimetro.
        {
            return 2 * (Largura + Altura);
        }
        public double CalcularDiag()//Uma função que faz a conta da diagonal.
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
        }
        public override string ToString()//override serve para colocar uma caixa de mensagem que deseja, para depois puxar de um jeito mais simples para o progrma principal.
        {
            return "Altura...: " + Altura.ToString("F2")
            + "\n"
            + "Largura...: " + Largura.ToString("F2")
            + "\n"
            + "Área......: " + CalcularArea().ToString("F2")
            + "\n"
            + "Perímetro.: " + CalcularPer().ToString("F2")
            + "\n"
            + "Diagonal..: " + CalcularDiag().ToString("F2");

        }
    }
}