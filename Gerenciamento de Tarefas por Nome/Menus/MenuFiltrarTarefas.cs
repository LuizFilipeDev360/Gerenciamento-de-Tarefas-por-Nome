using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Tarefas_por_Nome.Menus;

internal class MenuFiltrarTarefas
{
    private void MostrarDeAcordoComOFiltro(bool tipoDeFiltro, List<Tarefa> listaDeTarefas)
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

    public void MostrarMenu(List<Tarefa> listaDeTarefas)
    {
        Console.WriteLine("Digite 1 para filtrar por concluidas");
        Console.WriteLine("Digite 2 para filtrar por pendentes");
        string opcaoFiltrar = Console.ReadLine();
        bool tipoDeFiltro = false;

        Console.Clear();

        switch (opcaoFiltrar)
        {
            case "1":
                tipoDeFiltro = true;
                Console.WriteLine("Tarefas Concluídas:");
                MostrarDeAcordoComOFiltro(tipoDeFiltro, listaDeTarefas);
                break;
            case "2":
                tipoDeFiltro = false;
                Console.WriteLine("Tarefas Pendentes:");
                MostrarDeAcordoComOFiltro(tipoDeFiltro, listaDeTarefas);
                break;
            default:
                Console.Clear();
                Console.WriteLine("Opção inválida");
                break;
        }
    }
}
