using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ficha1Ex1
{
    class Utilizador { //Um utilizador tem um nome e um conjunto de tarefas
        public String nome{ get; set; }
        public List<Tarefa> tarefas { get; }

        public Utilizador(string name)
        {
            this.nome = name;
            tarefas = new List<Tarefa>();
        }

    }
}
