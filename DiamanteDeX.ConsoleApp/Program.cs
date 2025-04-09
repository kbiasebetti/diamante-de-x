namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirCabeçalho();
            ValidarNumeroImpar();
        }

        // Função para gerar o cabeçalho
        static void ExibirCabeçalho()
        {
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("|               Projeto Diamante de X                |");
            Console.WriteLine("| Digite um número ímpar para desenhar um X na tela! |");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("\n");
        }

        // Função para limpar tela e exibir o cabeçalho novamente (efeito nova aba)
        static void NovaAba()
        {
            Console.Clear();
            ExibirCabeçalho();
        }

        static int ValidarNumeroImpar()
        {

            while (true)
            {
                NovaAba();

                Console.Write("Digite um número ímpar: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine()); ;

                if (numeroDigitado == 0)
                {
                    Console.WriteLine("\nERRO: Digite um valor válido!");
                }
                else if (numeroDigitado % 2 == 1)
                {
                    Console.WriteLine($"> {numeroDigitado}");
                    return numeroDigitado;
                }
                else
                {
                    Console.WriteLine("\nERRO: Digite um valor ímpar e positivo!");
                }

                Console.WriteLine("Pressione ENTER para tentar novamente...");
                Console.ReadLine();
                continue;
            }
        }
    }
}
