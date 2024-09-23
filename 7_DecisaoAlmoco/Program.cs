string[] restaurantes = { "Restaurante Italiano", "Churrascaria", "Restaurante Japonês", "Fast-Food", "Restaurante Vegetariano" };
string[,] pratos = {
    { "Lasanha", "Pizza", "Espaguete" },                    // Italiano
    { "Picanha", "Costela", "Linguiça" },                   // Churrascaria
    { "Sushi", "Sashimi", "Tempurá" },                      // Japonês
    { "Hambúrguer", "Fritas", "Cachorro-Quente" },          // Fast-Food
    { "Salada", "Quibe de Abóbora", "Tofu Grelhado" }       // Vegetariano
};

Random aleatorio = new Random();

Console.WriteLine("Decisor de Almoço");
Console.WriteLine("1- Escolher restaurante");
Console.WriteLine("2- Escolher prato");
Console.WriteLine("3- Estou indeciso(a), escolha por mim");
Console.Write("Digite sua opção: ");
string escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine("Opções de Restaurantes");
        for (int i = 0; i < restaurantes.Length; i++)
            Console.WriteLine($"{i + 1}- {restaurantes[i]}");
        break;
}