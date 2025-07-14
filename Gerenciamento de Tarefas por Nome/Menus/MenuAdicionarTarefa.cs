using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Tarefas_por_Nome.Menus;

internal class MenuAdicionarTarefa
{
    public void MostrarMenu(List<Tarefa> listaDeTarefas)
    {
        Console.WriteLine("Digite a tarefa que deseja adicionar:");
        string tarefaParaAdicionar = Console.ReadLine();
        Tarefa tarefaNova = new Tarefa(tarefaParaAdicionar);
        listaDeTarefas.Add(tarefaNova);
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }
}
