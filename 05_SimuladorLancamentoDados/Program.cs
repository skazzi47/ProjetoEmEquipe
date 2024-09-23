Random aleatorio = new Random();

Console.WriteLine("Simulador de Lançamento de Dados");

while (true)
{
    int numeroAleatorio = aleatorio.Next(1, 7);
    Console.WriteLine($"O dado caiu em: {numeroAleatorio}");
    
    while (true)
    {        
        Console.Write("Jogar novamente? (S/N): ");
        string jogarDeNovo = Console.ReadLine().ToUpper();

        if (jogarDeNovo == "S")
            break;            
        else if (jogarDeNovo == "N")
        {
            Console.WriteLine("Saindo... Até a próxima!");
            return;
        }
        else
            Console.WriteLine("Opção inválida. Tente novamente.");
    }
}