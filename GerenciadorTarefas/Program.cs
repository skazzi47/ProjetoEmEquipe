void WriteTitle(string texto, int tamanho)
{
	Console.Clear();
	Console.ForegroundColor = ConsoleColor.Blue;
	Console.WriteLine(new string('=', tamanho));
	Console.WriteLine(texto);
	Console.WriteLine(new string('=', tamanho));
	Console.ResetColor();
}
void ColorLine(string texto, ConsoleColor cor)
{
	Console.ForegroundColor = cor;
	Console.WriteLine(texto);
	Console.ResetColor();
}

List<string> tarefas = new List<string>();
int opcao = 0, numeroTarefa;

do
{
    WriteTitle("Gerenciador de Tarefas", 22);
    Console.WriteLine("1- Adicionar Tarefa");
    Console.WriteLine("2- Listar Tarefas");
    Console.WriteLine("3- Remover Tarefa");
    Console.WriteLine("4- Editar Tarefa");
    Console.WriteLine("0- Sair");

    bool entradaInvalida = true;
    while (entradaInvalida)
    {
        Console.Write("Escolha uma opção: ");
        if (int.TryParse(Console.ReadLine(), out opcao))
        {
            entradaInvalida = false;

            switch (opcao)
            {
                case 1:
                    WriteTitle("Gerenciador de Tarefas :: Adicionar Tarefa", 42);
                    Console.Write("Digite a descrição da tarefa: ");
                    string tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    ColorLine("Tarefa adicionada com sucesso!", ConsoleColor.Green);
                    break;

                case 2:
                    WriteTitle("Gerenciador de Tarefas :: Lista de Tarefas", 42);
                    if (tarefas.Count == 0)
                    {
                        ColorLine("Nenhuma tarefa cadastrada.", ConsoleColor.DarkYellow);
                        entradaInvalida = false;
                    }
                    else
                    {
                        for (int i = 0; i < tarefas.Count; i++)
                            Console.WriteLine($"{i + 1}- {tarefas[i]}");
                    }
                    break;

                case 3:
                    WriteTitle("Gerenciador de Tarefas :: Remover Tarefa", 40);
                    entradaInvalida = true;
                    while (entradaInvalida)
                    {
                        Console.Write("Digite o número da tarefa que deseja remover: ");
                        if (int.TryParse(Console.ReadLine(), out numeroTarefa))
                        {
                            numeroTarefa -= 1;
                            if (numeroTarefa >= 0 && numeroTarefa < tarefas.Count)
                            {
                                tarefas.RemoveAt(numeroTarefa);
                                Console.WriteLine("Tarefa removida com sucesso!");
                                entradaInvalida = false;
                            }
                            else
                            {
                                ColorLine("Tarefa não encontrada.", ConsoleColor.DarkYellow);
                                entradaInvalida = false;
                            }
                        }
                        else
                            ColorLine("Entrada inválida. Tente novamente.", ConsoleColor.Red);
                    }
                    break;

                case 4:
                    WriteTitle("Gerenciador de Tarefas :: Editar Tarefa", 39);
                    entradaInvalida = true;
                    while (entradaInvalida)
                    {
                        Console.Write("Digite o número da tarefa que deseja editar: ");
                        if (int.TryParse(Console.ReadLine(), out numeroTarefa))
                        {
                            numeroTarefa -= 1;
                            if (numeroTarefa >= 0 && numeroTarefa < tarefas.Count)
                            {
                                Console.Write("Digite a nova descrição (ou deixe em branco para não alterar): ");
                                string novaDescricao = Console.ReadLine();

                                if (!string.IsNullOrWhiteSpace(novaDescricao))
                                {
                                    tarefas[numeroTarefa] = novaDescricao;
                                    ColorLine("Tarefa editada com sucesso!", ConsoleColor.Green);
                                }
                                entradaInvalida = false;
                            }
                            else
                            {
                                ColorLine("Tarefa não encontrada.", ConsoleColor.DarkYellow);
                                entradaInvalida = false;
                            }
                        }
                        else
                            ColorLine("Entrada inválida. Tente novamente.", ConsoleColor.Red);
                    }
                    break;

                case 0:
                    ColorLine("Saindo...", ConsoleColor.Cyan);
                    break;

                default:
                    ColorLine("Opção inválida! Tente novamente.", ConsoleColor.Red);
                    entradaInvalida = true;
                    break;
            }
        }
        else
            ColorLine("Opção inválida. Tente novamente.", ConsoleColor.Red);
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
} while (opcao != 0);