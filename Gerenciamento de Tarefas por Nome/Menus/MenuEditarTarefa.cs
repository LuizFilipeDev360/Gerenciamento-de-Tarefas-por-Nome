using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Tarefas_por_Nome.Menus;

internal class MenuEditarTarefa
{
    public void MostrarMenu(List<Tarefa> listaDeTarefas)
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
}
