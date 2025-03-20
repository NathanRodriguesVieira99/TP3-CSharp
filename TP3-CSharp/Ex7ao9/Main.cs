using System;

namespace Ex7a9
{
    public class Program
    {

        static void Main(string[] args)
        {
            Matricula matricula = new Matricula("Nathan", "EDS", 155, "22/02/2023");

            matricula.Trancar();

            matricula.Reativar();

            matricula.exibirInformacoes();
        }
    }
}