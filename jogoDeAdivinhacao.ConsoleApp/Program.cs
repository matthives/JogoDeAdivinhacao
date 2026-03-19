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

// 2. Nosso jogo deve gerar um número secreto aleatório

Console.WriteLine("-----------------------------------");
Console.WriteLine("Jogo de Adivinhação");
Console.WriteLine("-----------------------------------");

int numeroAleatorio = RandomNumberGenerator.GetInt32(1, 21);

Console.WriteLine();
Console.Write("Digite um número: ");
int numeroDigitado = Convert.ToInt32(Console.ReadLine());


if (numeroAleatorio == numeroDigitado)
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

Console.ReadLine();