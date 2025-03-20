using System;

namespace Ex7a9
{
    public class Matricula
    {
        private string NomeDoAluno;
        private string Curso;
        private int NumeroMatricula;
        private string Situacao;
        private string DataInicial;

        // construtor 

        public Matricula(string NomeDoAluno, string Curso, int NumeroMatricula, string DataInicial)
        {
            this.NomeDoAluno = NomeDoAluno;
            this.Curso = Curso;
            this.NumeroMatricula = NumeroMatricula;
            this.DataInicial = DataInicial;
            this.Situacao = "Ativa";
        }

        public void Trancar()
        {
            if (Situacao == "Ativa")
            {
                Situacao = "Trancada";
                Console.WriteLine("Matricula foi trancada");
            }
        }
        public void Reativar()
        {
            if (Situacao == "Trancada")
            {
                Situacao = "Ativa";
                Console.WriteLine("Matricula foi reativada");
            }
        }


        public void exibirInformacoes()
        {
            Console.WriteLine("Informações do aluno: ");
            Console.WriteLine($"Nome do aluno: {NomeDoAluno}");
            Console.WriteLine($"Curso: {Curso}");
            Console.WriteLine($"Situação : {Situacao}");
            Console.WriteLine($"Data da Matricula : {DataInicial}");

        }
    }
}