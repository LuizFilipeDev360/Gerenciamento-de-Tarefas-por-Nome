using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Tarefas_por_Nome;

internal class Tarefa
{
    public Tarefa(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; set; }
    public bool Concluida { get; set; } = false;

}
