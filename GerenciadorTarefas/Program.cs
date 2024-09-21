List<string> tarefas = new List<string>();

Console.WriteLine("Gerenciador de Tarefas");

Console.Write("Digite a descrição da tarefa: ");
string tarefa = Console.ReadLine();
tarefas.Add(tarefa);
Console.WriteLine("Tarefa adicionada com sucesso!");
Console.WriteLine(tarefas[0]);