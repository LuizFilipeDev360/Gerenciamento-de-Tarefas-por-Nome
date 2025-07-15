using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Tarefas_por_Nome.Menus;

internal class MenuRemoverTarefa
{
    public void MostrarMenu(List<Tarefa> listaDeTarefas)
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
}
