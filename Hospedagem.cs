
namespace quarto_de_aluguel
{
    class dados
    {
        //Declaração das variaveis onde são guardados as informações.
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public dados(string nome, string endereco, string email)
        {
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }
        public override string ToString()//override serve para colocar uma caixa de mensagem que deseja, para depois puxar de um jeito mais simples para o progrma principal.
        {
            return Nome
            + ", "
            + Endereco
            + ", "
            + Email;
        }
    }
    class quarto
    {
        public double diaria;
        public int meses;
        public double valor()
        {
            return diaria * meses;
        }
    }
}

