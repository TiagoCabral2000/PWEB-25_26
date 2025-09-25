using Ficha1Ex1;

public class Program
{
    public static void Main()
    {
        Utilizador user = new Utilizador("Tiago");

        Tarefa t1 = new Tarefa();
        t1.nome = "Tarefa 1";
        t1.categoria = Categoria.trabalho;
        t1.estado = Estado.em_execucao;
        t1.prioridade = Prioridade.alta;
        t1.dataCriacao = DateTime.Now;
        t1.dataLimite = DateTime.Now.AddDays(3);

        Console.WriteLine("O user {0} tem {1} tarefas", user.nome, user.tarefas.Count);
        user.tarefas.Add(t1);
        Console.WriteLine("O user {0} tem {1} tarefas", user.nome, user.tarefas.Count);

        Console.WriteLine(t1);
    }
}