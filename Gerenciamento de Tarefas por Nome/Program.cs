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
            var menuAdicionar = new MenuAdicionarTarefa();
            menuAdicionar.MostrarMenu(listaDeTarefas);
            VoltarAoMenuPrincipal();
            break;
        case "2":
            Console.Clear();
            var menuEditar = new MenuEditarTarefa();
            menuEditar.MostrarMenu(listaDeTarefas);
            VoltarAoMenuPrincipal();
            break;
        case "3":
            Console.Clear();
            var menuRemover = new MenuRemoverTarefa();
            menuRemover.MostrarMenu(listaDeTarefas);
            VoltarAoMenuPrincipal();
            break;
        case "4":
            Console.Clear();
            var menuMarcarTarefaConcluida = new MenuMarcarTarefaConcluida();
            menuMarcarTarefaConcluida.MostrarMenu(listaDeTarefas);
            VoltarAoMenuPrincipal();
            break;
        case "5":
            Console.Clear();
            var menuFiltrarTarefas = new MenuFiltrarTarefas();
            menuFiltrarTarefas.MostrarMenu(listaDeTarefas);
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

void VoltarAoMenuPrincipal()
{
    Console.WriteLine("Digite qualquer tecla para voltar ao Menu Principal");
    Console.ReadKey();
    Console.Clear();
    MenuPrincipal();
}