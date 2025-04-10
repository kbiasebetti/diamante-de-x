namespace DiamanteDeX.ConsoleApp
{
	internal class Program
	{
		// Função principal para coordenar o fluxo
		static void Main(string[] args)
		{
			while (true)
			{ 
				ExibirCabeçalho();
				int numeroValidado = ValidarNumeroImpar();
				DesenharDiamante(numeroValidado);

				// Estrutura de verificação para fazer um novo triângulo 
				while (true)
				{
					Console.Write("\nDeseja fazer um novo triângulo? (s/n): ");
					string valorNovoTriangulo = Console.ReadLine();

					if (valorNovoTriangulo.ToLower() == "s")
						break;
					else if (valorNovoTriangulo.ToLower() == "n")
						return;
					else 
					{
						NovaAba();
						Console.WriteLine("\nERRO: Digite um valor válido!");
					}
				}
			}
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


		// Função de validação de valores e interação do usuário
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
					Console.WriteLine($">{numeroDigitado}");
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


		// Função para desenhar o diamante
		static void DesenharDiamante(int tamanhoDiamante)
		{

			NovaAba();
			Console.WriteLine($"Diamante de tamanho: {tamanhoDiamante}\n");

			int centroDiamante = tamanhoDiamante / 2;

			// Triângulo para a parte de cima (com a linha do meio)
			for (int i = 0; i <= centroDiamante; i++)
			{
				int espacosNecessarios = centroDiamante - i;
				int quantidadeDeX = 2 * i + 1;

				string linhaDiamante = new string(' ', espacosNecessarios) + new string('X', quantidadeDeX);
				Console.WriteLine(linhaDiamante);
			}

			// Triângulo para a parte de baixo 
			for (int i = centroDiamante - 1; i >= 0; i--)
			{
				int espaçosNecessarios = centroDiamante - i;
				int quantidadeDeX = 2 * i + 1;

				string linhaDiamante = new string(' ', espaçosNecessarios) + new string('X', quantidadeDeX);
				Console.WriteLine(linhaDiamante);
			}

			Console.ReadLine();
		}
	}
}