List<string> tarefas = new List<string>();
int opcao;

while (true)
{
    Console.WriteLine("Gerenciador de Tarefas");
    Console.WriteLine("1- Adicionar Tarefa");
    Console.WriteLine("2- Listar Tarefas");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Write("Digite a descrição da tarefa: ");
            string tarefa = Console.ReadLine();
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada com sucesso!");
            break;
        case 2:
            Console.WriteLine("Tarefas:");
            for (int i = 0; i < tarefas.Count; i++)
                Console.WriteLine($"□ {tarefas[i]}");
            if (tarefas.Count == 0)
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            break;
    }
}