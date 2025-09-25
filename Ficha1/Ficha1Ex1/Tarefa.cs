using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

public enum Prioridade
{
    baixa,
    normal,
    alta
}

public enum Categoria
{
    pessoal,
    trabalho
}

public enum Estado
{
    por_executar,
    em_execucao,
    concluida
}


namespace Ficha1Ex1
{
    class Tarefa{
        public String nome { get; set; }
        public Prioridade prioridade { get; set; }
        public Categoria categoria { get; set; }
        public Estado estado { get; set; }
        public DateTime dataCriacao { get; set; }
        public DateTime dataLimite { get; set; }

        public override string ToString()
        {
            return $"\n{{\n\tNome: \"{nome}\", \n\tPrioridade: {prioridade}, " +
                   $"\n\tCategoria: {categoria}, \n\tEstado: {estado}, " +
                   $"\n\tDataRegisto: {dataCriacao}, \n\tDataLimite: {dataLimite}\n}}\n";
        }

    }
}
