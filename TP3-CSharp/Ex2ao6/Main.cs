using System;

namespace Ex2ao6
{
    public class Program
    {
        static void Main(string[] args)
        {
            // SEM O CONSTRUTOR
            // Ingresso ingresso = new Ingresso();
            // ingresso.NomeDoShow = "Sepultura Roots Brasil Tour";
            // ingresso.preco = 250.00;
            // ingresso.quantidadeDisponivel = 1200;
            // ingresso.exibirInformacoes(); 

            // ingresso.alterarPreco(300.00);
            // ingresso.alterarQuantidade(1900);
            // ingresso.exibirInformacoes();


            // ingresso.SetNomeDoShow("Soulfly Totem Brasil Tour");
            // ingresso.GetNomeDoShow();
            // ingresso.SetPreco(150.00);
            // ingresso.GetPreco();
            // ingresso.SetQuantidadeDisponivel(1000);
            // ingresso.GetQuantidadeDisponivel();

            // ingresso.exibirInformacoes();



            // COM CONSTRUTOR
            Ingresso ingresso = new Ingresso("Gray Day Tour 2025", 159.00, 59);

            ingresso.exibirInformacoes();
        }
    }
}