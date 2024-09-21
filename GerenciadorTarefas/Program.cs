List<string> tarefas = new List<string>();
int opcao;

while (true)
{
    Console.WriteLine("Gerenciador de Tarefas");
    Console.WriteLine("1- Adicionar Tarefa");
    Console.WriteLine("2- Listar Tarefas");
    Console.WriteLine("3- Remover Tarefa");
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
                Console.WriteLine($"{i + 1}- {tarefas[i]}");
            if (tarefas.Count == 0)
                Console.WriteLine("Nenhuma tarefa cadastrada.");
            break;
        case 3:
            Console.Write("Digite o número da tarefa que deseja remover: ");
            int numeroTarefa = int.Parse(Console.ReadLine()) - 1;
            if (numeroTarefa >= 0 && numeroTarefa < tarefas.Count)
            {
                tarefas.RemoveAt(numeroTarefa);
                Console.WriteLine("Tarefa removida com sucesso!");
            }
            else
                Console.WriteLine("Tarefa não encontrada.");
            break;
    }
}