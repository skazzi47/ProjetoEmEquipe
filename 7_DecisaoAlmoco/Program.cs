void WriteTitle()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(@"   ___          _                   __      ___   __                  ");
    Console.WriteLine(@"  / _ \___ ____(_)__ ___  ____  ___/ /__   / _ | / /_ _  ___  _______ ");
    Console.WriteLine(@" / // / -_) __/ (_-</ _ \/ __/ / _  / -_) / __ |/ /  ' \/ _ \/ __/ _ \");
    Console.WriteLine(@"/____/\__/\__/_/___/\___/_/    \_,_/\__/ /_/ |_/_/_/_/_/\___/\__/\___/");
    Console.WriteLine("                                                              /_)      ");
    Console.ResetColor();
}
void WriteSubtitle(string texto)
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine(texto);
    Console.ResetColor();
}
void ColorLineRed(string texto)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(texto);
    Console.ResetColor();
}

List<string> restaurantes = ["Restaurante Italiano", "Churrascaria", "Restaurante Japonês", "Fast-Food", "Restaurante Vegetariano"];
List<List<string>> pratosPorRestaurante = [
    [ "Lasanha de Berinjela", "Pizza Margherita", "Torta de Ricota" ],       // Italiano
    [ "Batata Frita", "Picanha na Brasa", "Pizza Margherita" ],              // Churrascaria
    [ "Hot Roll", "Ramen Tonkotsu", "Tempura de Legumes" ],                  // Japonês
    [ "Batata Frita", "Cheeseburger", "Hot Roll" ],                          // Fast-Food
    [ "Lasanha de Berinjela", "Salada Caesar Vegana", "Tempura de Legumes" ] // Vegetariano
];
Random aleatorio = new Random();
int numMenu = 0, numRestaurante = 0, numPrato = 0;

WriteTitle();
Console.WriteLine("1- Escolher restaurante");
Console.WriteLine("2- Escolher prato");
Console.WriteLine("3- Estou indeciso(a), escolha por mim");
while (true)
{
    Console.Write("Digite sua opção: ");
    if (int.TryParse(Console.ReadLine(), out numMenu) && numMenu == 1 || numMenu == 2 || numMenu == 3)
        break;
    else
        ColorLineRed("Opção inválida. Tente novamente.");
}

switch (numMenu)
{
    case 1:
        WriteTitle();
        WriteSubtitle("Opções de Restaurantes");
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
                ColorLineRed("Opção inválida. Tente novamente.");
        }
        WriteTitle();
        WriteSubtitle($"Opções de Pratos em {restaurantes[numRestaurante]}");
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
                ColorLineRed("Opção inválida. Tente novamente.");
        }
        WriteTitle();
        Console.WriteLine($"Você escolheu almoçar {pratosPorRestaurante[numRestaurante][numPrato]} em {restaurantes[numRestaurante]}. Uma ótima pedida!");
        break;

    case 2:
        WriteTitle();
        HashSet<string> pratosUnicos = [];

        foreach (var pratos in pratosPorRestaurante)
            pratosUnicos.UnionWith(pratos);

        List<string> listaPratos = pratosUnicos.ToList();

        WriteSubtitle("Opções de Pratos");
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
                ColorLineRed("Opção inválida. Tente novamente.");
        }

        List<string> restaurantesComPrato = [];

        for (int i = 0; i < restaurantes.Count; i++)
        {
            if (pratosPorRestaurante[i].Contains(listaPratos[numPrato]))
                restaurantesComPrato.Add(restaurantes[i]);
        }
        if (restaurantesComPrato.Count > 0)
        {
            WriteSubtitle($"Restaurantes que oferecem {listaPratos[numPrato]}");

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
                    ColorLineRed("Opção inválida. Tente novamente.");
            }
            WriteTitle();
            Console.WriteLine($"Você escolheu almoçar {listaPratos[numPrato]} em {restaurantesComPrato[numRestaurante]}. Uma ótima pedida!");
        }
        break;

    case 3:
        WriteTitle();
        WriteSubtitle("3 - Estou indeciso(a), escolha por mim");
        int restauranteAleatorio = aleatorio.Next(restaurantes.Count);
        int pratoAleatorio = aleatorio.Next(pratosPorRestaurante[restauranteAleatorio].Count);
        Console.WriteLine($"Sugiro que almoce {pratosPorRestaurante[restauranteAleatorio][pratoAleatorio]} em {restaurantes[restauranteAleatorio]}. Que tal?");
        break;

    default:
        ColorLineRed("Opção inválida. Tente novamente.");
        break;
}