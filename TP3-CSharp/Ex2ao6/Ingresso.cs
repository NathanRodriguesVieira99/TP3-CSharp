using System;

namespace Ex2ao6
{
    public class Ingresso
    {
        public string? NomeDoShow;
        public double preco;
        public int quantidadeDisponivel;

        // construtor 
        public Ingresso(string NomeDoShow, double preco, int quantidadeDisponivel)
        {
            this.NomeDoShow = NomeDoShow;
            this.preco = preco;
            this.quantidadeDisponivel = quantidadeDisponivel;
        }

        // gets
        public string GetNomeDoShow()
        {
            return NomeDoShow;
        }
        public double GetPreco()
        {
            return preco;
        }
        public int GetQuantidadeDisponivel()
        {
            return quantidadeDisponivel;
        }

        // sets
        public void SetNomeDoShow(string NovoNome)
        {
            this.NomeDoShow = NovoNome;
        }
        public void SetPreco(double NovoPreco)
        {
            this.preco = NovoPreco;
        }

        public void SetQuantidadeDisponivel(int novaQuantidade)
        {
            this.quantidadeDisponivel = novaQuantidade;
        }




        public void alterarPreco(double novoPreco)
        {
            this.preco = novoPreco;
        }
        public void alterarQuantidade(int novaQuantidade)
        {
            this.quantidadeDisponivel = novaQuantidade;
        }

        public void exibirInformacoes()
        {
            Console.WriteLine("Informações do Ingresso");
            Console.WriteLine($"Nome do Show: {NomeDoShow}");
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Quantidade disponível: {quantidadeDisponivel}");
        }
    }
}