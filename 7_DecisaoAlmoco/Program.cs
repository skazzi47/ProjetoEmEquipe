List<string> restaurantes = ["Restaurante Italiano", "Churrascaria", "Restaurante Japonês", "Fast-Food", "Restaurante Vegetariano"];
List<List<string>> pratosPorRestaurante = [
    [ "Lasanha de Berinjela", "Pizza Margherita", "Torta de Ricota" ],       // Italiano
    [ "Batata Frita", "Picanha na Brasa", "Pizza Margherita" ],              // Churrascaria
    [ "Hot Roll", "Ramen Tonkotsu", "Tempura de Legumes" ],                  // Japonês
    [ "Batata Frita", "Cheeseburger", "Hot Roll" ],                          // Fast-Food
    [ "Lasanha de Berinjela", "Salada Caesar Vegana", "Tempura de Legumes" ] // Vegetariano
];
Random aleatorio = new Random();
int numMenu = 0;
int numRestaurante = 0;
int numPrato = 0;

Console.WriteLine("Decisor de Almoço");
Console.WriteLine("1- Escolher restaurante");
Console.WriteLine("2- Escolher prato");
Console.WriteLine("3- Estou indeciso(a), escolha por mim");
while (true)
{
    Console.Write("Digite sua opção: ");
    if (int.TryParse(Console.ReadLine(), out numMenu) && numMenu == 1 || numMenu == 2)
        break;
    else
        Console.WriteLine("Opção inválida. Tente novamente.");
}

switch (numMenu)
{
    case 1:
        Console.WriteLine("Opções de Restaurantes");
        for (int i = 0; i < restaurantes.Count(); i++)
            Console.WriteLine($"{i + 1}- {restaurantes[i]}");

        while (true)
        {
            Console.Write("Digite sua opção: ");
            if (int.TryParse(Console.ReadLine(), out numRestaurante) && numRestaurante > 0 && numRestaurante <= restaurantes.Count)
            {
                numRestaurante--;
                break;
            }
            else
                Console.WriteLine("Opção inválida. Tente novamente.");
        }
        Console.WriteLine($"Opções de Pratos em {restaurantes[numRestaurante]}");
        for (int i = 0; i < pratosPorRestaurante[numRestaurante].Count; i++)
            Console.WriteLine($"{i + 1}- {pratosPorRestaurante[numRestaurante][i]}");

        while (true)
        {
            Console.Write("Digite sua opção: ");
            if (int.TryParse(Console.ReadLine(), out numPrato) && numPrato > 0 && numPrato <= pratosPorRestaurante[numRestaurante].Count)
            {
                numPrato--;
                break;
            }
            else
                Console.WriteLine("Opção inválida. Tente novamente.");
        }

        Console.WriteLine($"Você escolheu almoçar {pratosPorRestaurante[numRestaurante][numPrato]} em {restaurantes[numRestaurante]}. Uma ótima pedida!");
        break;

    case 2:
        HashSet<string> pratosUnicos = [];

        foreach (var pratos in pratosPorRestaurante)
            pratosUnicos.UnionWith(pratos);

        List<string> listaPratos = pratosUnicos.ToList();

        Console.WriteLine("Opções de Pratos");
        for (int i = 0; i < listaPratos.Count; i++)
            Console.WriteLine($"{i + 1}- {listaPratos[i]}");

        while (true)
        {
            Console.Write("Digite sua opção: ");
            if (int.TryParse(Console.ReadLine(), out numPrato) && numPrato > 0 && numPrato <= listaPratos.Count)
            {
                numPrato--;
                break;
            }
            else
                Console.WriteLine("Opção inválida. Tente novamente.");
        }

        List<string> restaurantesComPrato = [];

        for (int i = 0; i < restaurantes.Count; i++)
        {
            if (pratosPorRestaurante[i].Contains(listaPratos[numPrato]))
                restaurantesComPrato.Add(restaurantes[i]);
        }
        if (restaurantesComPrato.Count > 0)
        {
            Console.WriteLine($"Restaurantes que oferecem {listaPratos[numPrato]}");

            for (int i = 0; i < restaurantesComPrato.Count; i++)
                Console.WriteLine($"{i + 1}- {restaurantesComPrato[i]}");

            while (true)
            {
                Console.Write("Digite sua opção: ");
                if (int.TryParse(Console.ReadLine(), out numRestaurante) && numRestaurante > 0 && numRestaurante <= restaurantesComPrato.Count)
                {
                    numRestaurante--;
                    break;
                }
                else
                    Console.WriteLine("Opção inválida. Tente novamente.");
            }

            Console.WriteLine($"Você escolheu almoçar {listaPratos[numPrato]} em {restaurantesComPrato[numRestaurante]}. Uma ótima pedida!");
        }
        break;

    case 3:
        int restauranteAleatorio = aleatorio.Next(restaurantes.Count);
        int pratoAleatorio = aleatorio.Next(pratosPorRestaurante[restauranteAleatorio].Count);
        Console.WriteLine($"Que tal almoçar {pratosPorRestaurante[restauranteAleatorio][pratoAleatorio]} em {restaurantes[restauranteAleatorio]}?");
        break;
}