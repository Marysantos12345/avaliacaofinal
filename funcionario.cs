using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;namespace Exercicio2
{
    class Dados_Funcionario
    {
        //Declaração das variaveis onde são guardados as informações.
        public string Nome { get; set; }
        public double SalarioBruto { get; set; }
        public double Imposto { get; set; }
        public Dados_Funcionario(string nome, double salarioBruto, double imposto)
        {
            Nome = nome;
            SalarioBruto = salarioBruto;
            Imposto = imposto;
        }
        public double CalcularSalarioLiquido() //Uma função que faz a conta SalarioBruto - Imposto.
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double perct_aumento)//Uma função que faz a conta para aumentar o selário
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * perct_aumento / 100.00);
        }
        public override string ToString() //override serve para colocar uma caixa de mensagem que deseja, para depois puxar de um jeito mais simples para o progrma principal.
        {
            return "O funcionário " + Nome.ToUpper()
            + "\nRecebe R$ " + SalarioBruto.ToString("F2")
            + " de salário bruto. "
            + "\nCom imposto R$ " + Imposto.ToString("F2")
            + "\nTendo salário liquído de R$ " + CalcularSalarioLiquido();
        }
    }
}

