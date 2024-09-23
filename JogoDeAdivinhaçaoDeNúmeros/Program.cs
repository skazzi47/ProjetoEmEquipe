using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("|\tAdivinhe O Número!\t|\n");
        Console.WriteLine("Você deve adivinhar o número de 1 à 100:\n");
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 100);
        Console.WriteLine("Número Gerado! Agora tente adivinhar qual número foi gerado:\n");
        return1:
        if(int.TryParse(Console.ReadLine(),out int palpite));
        {
            if(palpite == numeroAleatorio)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você ACERTOU!\n");
                Console.ResetColor();
            }
            else if(palpite < numeroAleatorio)
            {
                Console.WriteLine("O número gerado é maior!\n");
                goto return1;
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("O número gerado é menor!\n");
                goto return1;
            }
        }
    }
}