using Gerenciamento_de_Tarefas_por_Nome;
using Gerenciamento_de_Tarefas_por_Nome.Menus;

List<Tarefa> listaDeTarefas = new List<Tarefa>();
listaDeTarefas.Add(new Tarefa("Acordar"));
listaDeTarefas.Add(new Tarefa("Estudar"));
listaDeTarefas.Add(new Tarefa("Comer"));
listaDeTarefas[0].Concluida = true;

MenuPrincipal();

void MenuPrincipal()
{
    Console.WriteLine("Bem Vindo a Lista De Tarefas!");
    Console.WriteLine("Tarefas:");

    foreach (Tarefa ta in listaDeTarefas)
    {
        if (ta.Concluida == true)
        {
            Console.WriteLine($"    {ta.Nome}(Concluída)");
        }
        else
        {
            Console.WriteLine($"    {ta.Nome}(Pendente)");
        }
    }
    Console.WriteLine("\n\n\n");
    Console.WriteLine("Digite 1 para adicionar uma tarefa");
    Console.WriteLine("Digite 2 para editar uma tarefa");
    Console.WriteLine("Digite 3 para remover uma tarefa");
    Console.WriteLine("Digite 4 para marcar uma tarefa como concluída");
    Console.WriteLine("Digite 5 para filtrar tarefas");
    Console.WriteLine("Digite -1 para sair");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            var MenuAdicionar = new MenuAdicionarTarefa();
            MenuAdicionar.MostrarMenu(listaDeTarefas);
            VoltarAoMenuPrincipal();
            break;
        case "2":
            Console.Clear();
            EditarTarefa();
            VoltarAoMenuPrincipal();
            break;
        case "3":
            Console.Clear();
            RemoverTarefa();
            VoltarAoMenuPrincipal();
            break;
        case "4":
            Console.Clear();
            MarcarConcluidaTarefa();
            VoltarAoMenuPrincipal();
            break;
        case "5":
            Console.Clear();
            FiltrarTarefas();
            VoltarAoMenuPrincipal();
            break;
        case "-1":
            Console.WriteLine("Até mais :) !!!");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            VoltarAoMenuPrincipal();
            break;
    }

}

void MostrarDeAcordoComOFiltro(bool tipoDeFiltro)
{
    foreach (Tarefa ta in listaDeTarefas)
    {
        if (ta.Concluida == tipoDeFiltro)
        {
            string estadoAtual = ta.Concluida ? "Concluida" : "pendente";
            Console.WriteLine($"    {ta.Nome}({estadoAtual})");
        }
    }
}

void FiltrarTarefas()
{
    Console.WriteLine("Digite 1 para filtrar por concluidas");
    Console.WriteLine("Digite 2 para filtrar por pendentes");
    string opcaoFiltrar = Console.ReadLine();
    bool tipoDeFiltro = false;

    switch (opcaoFiltrar)
    {
        case "1":
            tipoDeFiltro = true;
            MostrarDeAcordoComOFiltro(tipoDeFiltro);
            break;
        case "2":
            tipoDeFiltro = false;
            MostrarDeAcordoComOFiltro(tipoDeFiltro);
            break;
        default:
            Console.Clear();
            Console.WriteLine("Opção inválida");
            break;
    }
}

void MarcarConcluidaTarefa()
{
    Console.WriteLine("Digite a tarefa que deseja marcar como concluida:");
    string tarefaParaConcluir = Console.ReadLine();
    bool encontrado = false;

    foreach (Tarefa ta in listaDeTarefas)
    {
        if (ta.Nome == tarefaParaConcluir)
        {
            encontrado = true;
            if(ta.Concluida == false)
            {
                ta.Concluida = true;
                Console.WriteLine($"Tarefa {ta.Nome} concluida com sucesso");
            }
            else
            {
                Console.WriteLine("A tarefa já está concluida");
            }
        }
    }

    if (encontrado == false)
    {
        Console.WriteLine("Tarefa não encontrada");
    }
}

void RemoverTarefa()
{
    Console.WriteLine("Digite a tarefa que deseja remover:");
    string tarefaParaRemover = Console.ReadLine();
    bool encontrado = false;
    Tarefa objetoParaRemover;

    for (int i = 0; i < listaDeTarefas.Count; i++)
        {
            if (listaDeTarefas[i].Nome == tarefaParaRemover)
            {
                listaDeTarefas.RemoveAt(i);
                encontrado = true;
                Console.WriteLine($"tarefa {tarefaParaRemover} removida com sucesso!");
                i--;
            }
        }

    if (encontrado == false)
    {
        Console.WriteLine("Tarefa não encontrada");
    }
}

void EditarTarefa()
{
    Console.WriteLine("Digite a tarefa que deseja editar:");
    string tarefaParaEditar = Console.ReadLine();
    bool encontrado = false;

    foreach (Tarefa ta in listaDeTarefas)
    {
        if (ta.Nome == tarefaParaEditar)
        {
            Console.WriteLine($"Deseja Editar a tarefa {ta.Nome} para:");
            string mudancaTarefa = Console.ReadLine();
            ta.Nome = mudancaTarefa;
            Console.WriteLine($"Tarefa {tarefaParaEditar} editada para {ta.Nome} com sucesso");
            encontrado = true;
        }
    }

    if (encontrado == false)
    {
        Console.WriteLine("Tarefa não encontrada");
    }
}

void VoltarAoMenuPrincipal()
{
    Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}