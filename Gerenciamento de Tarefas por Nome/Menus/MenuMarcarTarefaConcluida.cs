using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Tarefas_por_Nome.Menus;

internal class MenuMarcarTarefaConcluida
{
    public void MostrarMenu(List<Tarefa> listaDeTarefas)
    {
        Console.WriteLine("Digite a tarefa que deseja marcar como concluida:");
        string tarefaParaConcluir = Console.ReadLine();
        bool encontrado = false;

        foreach (Tarefa ta in listaDeTarefas)
        {
            if (ta.Nome == tarefaParaConcluir)
            {
                encontrado = true;
                if (ta.Concluida == false)
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
}
