string[] restaurantes = { "Restaurante Italiano", "Churrascaria", "Restaurante Japonês", "Fast-Food", "Restaurante Vegetariano" };
string[,] pratos = {
    { "Lasanha de Berinjela", "Pizza Margherita", "Torta de Ricota" },       // Italiano
    { "Batata Frita", "Picanha na Brasa", "Pizza Margherita"  },             // Churrascaria
    { "Hot Roll", "Ramen Tonkotsu", "Tempura de Legumes" },                  // Japonês
    { "Batata Frita", "Cheeseburger", "Hot Roll" },                          // Fast-Food
    { "Lasanha de Berinjela", "Salada Caesar Vegana", "Tempura de Legumes" } // Vegetariano
};

Random aleatorio = new Random();

Console.WriteLine("Decisor de Almoço");
Console.WriteLine("1- Escolher restaurante");
Console.WriteLine("2- Escolher prato");
Console.WriteLine("3- Estou indeciso(a), escolha por mim");
Console.Write("Digite sua opção: ");
string numMenu = Console.ReadLine();

switch (numMenu)
{
    case "1":
        Console.WriteLine("Opções de Restaurantes");
        for (int i = 0; i < restaurantes.Length; i++)
        {
            Console.WriteLine($"{i + 1}- {restaurantes[i]}");
        }
        Console.Write("Digite sua opção: ");
        int numRestaurante = int.Parse(Console.ReadLine()) - 1;
        if (numRestaurante >= 0 && numRestaurante < restaurantes.Length)
        {
            Console.WriteLine($"Opções de Pratos em {restaurantes[numRestaurante]}");
            for (int i = 0; i < pratos.GetLength(1); i++)
            {
                Console.WriteLine($"{i + 1}- {pratos[numRestaurante, i]}");
            }
        }
        Console.Write("Digite sua opção: ");
        int numPrato = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"Você escolheu almoçar {pratos[numRestaurante, numPrato]} em {restaurantes[numRestaurante]}. Uma ótima pedida!");
        break;
}