namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabeçalho();
        }

        // Função para gerar o cabeçalho
        static void ExibirCabeçalho()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|               Projeto Diamante de X                |");
            Console.WriteLine("| Digite um número ímpar para desenhar um X na tela! |");
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
