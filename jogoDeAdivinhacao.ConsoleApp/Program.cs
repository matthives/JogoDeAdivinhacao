using System.Security.Cryptography;

/*
v1

Iremos fazer um jogo onde o usuário terá chances de acertar um número aleatório decidido pelo sistema.

Input (Entrada de Dados)
      o usuário digita número inteiro
Processamento
      O sistema compara o número digitado com o número inteiro aleatório
Output (Saída de Dados)
    O sistema informará o usuário se o mesmo acertou ou não, podendo incluir dicas sobre a proximidade do "chute"
*/

// 2. Nosso jogo deve permitir múltiplas tentativas de adivinhação
int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

bool jogoDeveContinuar = true;

while (jogoDeveContinuar == true)
{


    Console.Clear();
    Console.WriteLine("-----------------------------------");
    Console.WriteLine("Jogo de Adivinhação");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine();
    Console.Write("Digite um número: ");
    int numeroDigitado = Convert.ToInt32(Console.ReadLine());


    if (numeroDigitado == numeroAleatorio)
    {
        Console.WriteLine("Parabéns, você acertou! O número era " + numeroAleatorio);
    }

    else if (numeroDigitado > numeroAleatorio)
    {
        Console.WriteLine("O número digitado foi maior que o número secreto!");
    }

    else
    {
        Console.WriteLine("O número digitado foi maior que o número secreto!");
    }

    Console.WriteLine();
    Console.Write("Deseja continuar? (s/N): ");
    string opcaoContinuar = Console.ReadLine();

    if (opcaoContinuar != "S" && opcaoContinuar != "s")
    {
        jogoDeveContinuar = false;
    }
}