namespace TP3_CSharp;

public class Assassino
{
    private string nome;
    private string mestre;
    private string irmandade;

    public string CriarAssassino()
    {
        Console.WriteLine("Informe os dados do iniciado assassino: ");
        Console.Write("Nome: ");
        this.nome = Console.ReadLine();
        Console.Write("Mestre: ");
        this.mestre = Console.ReadLine();
        Console.Write("Irmandade: ");
        this.irmandade = Console.ReadLine();

        return $"Nome: {this.nome}, Mestre: {this.mestre}, Irmandade: {this.irmandade}";

    }

    static void Main(string[] args)
    {
        Assassino assassino = new Assassino();

        string cadastrarNovoMembro = assassino.CriarAssassino();

        Console.WriteLine("Dados do membro cadastrado: " + cadastrarNovoMembro);

    }
}
