List<string> tarefas = new List<string>();
int opcao = 0, numeroTarefa;

do
{
    Console.Clear();
    Console.WriteLine("Gerenciador de Tarefas");
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
                    Console.Clear();
                    Console.Write("Digite a descrição da tarefa: ");
                    string tarefa = Console.ReadLine();
                    tarefas.Add(tarefa);
                    Console.WriteLine("Tarefa adicionada com sucesso!");
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("Tarefas:");
                    if (tarefas.Count == 0)
                    {
                        Console.WriteLine("Nenhuma tarefa cadastrada.");
                        entradaInvalida = false;
                    }
                    else
                    {
                        for (int i = 0; i < tarefas.Count; i++)
                            Console.WriteLine($"{i + 1}- {tarefas[i]}");
                    }
                    break;

                case 3:
                    Console.Clear();
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
                                Console.WriteLine("Tarefa não encontrada.");
                                entradaInvalida = false;
                            }
                        }
                        else
                            Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
                    break;

                case 4:
                    Console.Clear();
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
                                    Console.WriteLine("Tarefa editada com sucesso!");
                                }
                                entradaInvalida = false;
                            }
                            else
                            {
                                Console.WriteLine("Tarefa não encontrada.");
                                entradaInvalida = false;
                            }
                        }
                        else
                            Console.WriteLine("Entrada inválida. Tente novamente.");
                    }
                    break;

                case 0:
                    Console.WriteLine("Saindo...");
                    break;

                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    entradaInvalida = true;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
        }
    }
    Console.WriteLine("Pressione qualquer tecla para continuar...");
    Console.ReadKey();
} while (opcao != 0);