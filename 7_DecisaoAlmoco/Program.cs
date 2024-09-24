List<string> restaurantes = ["Restaurante Italiano", "Churrascaria", "Restaurante Japonês", "Fast-Food", "Restaurante Vegetariano"];
List<List<string>> pratosPorRestaurante = [
    [ "Lasanha de Berinjela", "Pizza Margherita", "Torta de Ricota" ],       // Italiano
    [ "Batata Frita", "Picanha na Brasa", "Pizza Margherita" ],              // Churrascaria
    [ "Hot Roll", "Ramen Tonkotsu", "Tempura de Legumes" ],                  // Japonês
    [ "Batata Frita", "Cheeseburger", "Hot Roll" ],                          // Fast-Food
    [ "Lasanha de Berinjela", "Salada Caesar Vegana", "Tempura de Legumes" ] // Vegetariano
];
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
        for (int i = 0; i < restaurantes.Count(); i++)
            Console.WriteLine($"{i + 1}- {restaurantes[i]}");

        Console.Write("Digite sua opção: ");
        int numRestaurante = int.Parse(Console.ReadLine()) - 1;
        if (numRestaurante >= 0 && numRestaurante < restaurantes.Count())
        {
            Console.WriteLine($"Opções de Pratos em {restaurantes[numRestaurante]}");
            for (int i = 0; i < pratosPorRestaurante[numRestaurante].Count; i++)
                Console.WriteLine($"{i + 1}- {pratosPorRestaurante[numRestaurante][i]}");
        }
        Console.Write("Digite sua opção: ");
        int numPrato = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine($"Você escolheu almoçar {pratosPorRestaurante[numRestaurante][numPrato]} em {restaurantes[numRestaurante]}. Uma ótima pedida!");
        break;
    case "2":
        HashSet<string> pratosUnicos = [];

        foreach (var pratos in pratosPorRestaurante)
            pratosUnicos.UnionWith(pratos);

        List<string> listaPratos = pratosUnicos.ToList();

        Console.WriteLine("Opções de Pratos");
        for (int i = 0; i < listaPratos.Count; i++)
            Console.WriteLine($"{i + 1}- {listaPratos[i]}");

        Console.Write("Digite sua opção: ");
        numPrato = int.Parse(Console.ReadLine());
        if (numPrato >= 0 && numPrato < listaPratos.Count)
        {
            List<string> restaurantesComPrato = [];

            for (int i = 0; i < restaurantes.Count; i++)
            {
                if (pratosPorRestaurante[i].Contains(listaPratos[numPrato - 1]))
                    restaurantesComPrato.Add(restaurantes[i]);
            }
            if (restaurantesComPrato.Count > 0)
            {
                Console.WriteLine($"Restaurantes que oferecem {listaPratos[numPrato - 1]}");

                for (int i = 0; i < restaurantesComPrato.Count; i++)
                    Console.WriteLine($"{i + 1}- {restaurantesComPrato[i]}");

                Console.Write("Digite sua opção: ");
                numRestaurante = int.Parse(Console.ReadLine()) - 1;
                Console.WriteLine($"Você escolheu almoçar {listaPratos[numPrato - 1]} em {restaurantesComPrato[numRestaurante]}. Uma ótima pedida!");
            }
        }
        break;
}