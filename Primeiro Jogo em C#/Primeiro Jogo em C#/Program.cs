Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do
{
    Console.Write("\nDigite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if (chute == numeroSecreto)
    {
        Console.WriteLine("Parabéns! Você acertou o número.");
        break;
    }
    else if (chute < numeroSecreto)
    {
        Console.WriteLine("\nO número é maior.");
    }
    else
    {
        Console.WriteLine("\nO número é menor.");
    }

} while (true);

Console.WriteLine("\nO jogo acabou. Você acertou o número secreto, meus parabéns!!!");