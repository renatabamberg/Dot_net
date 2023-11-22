using System;
using System.Collections.Generic;
using System.Linq;

class Tarefa
{
    public string Titulo { get; set; }
    public bool Concluida { get; set; }
}

class Program
{
    static void Main()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        string opcao = "";

        while (opcao != "5")
        {
            Console.WriteLine("1. Adicionar tarefa");
            Console.WriteLine("2. Ver tarefas");
            Console.WriteLine("3. Marcar tarefa como concluída");
            Console.WriteLine("4. Excluir tarefa");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a tarefa: ");
                    string titulo = Console.ReadLine();
                    tarefas.Add(new Tarefa { Titulo = titulo, Concluida = false });
                    break;
                case "2":
                    Console.WriteLine("Tarefas:");
                    foreach (Tarefa t in tarefas)
                    {
                        Console.WriteLine(t.Titulo + (t.Concluida ? " (concluída)" : ""));
                    }
                    break;
                case "3":
                    Console.Write("Digite a tarefa a ser marcada como concluída: ");
                    titulo = Console.ReadLine();
                    Tarefa tarefa = tarefas.FirstOrDefault(t => t.Titulo == titulo);
                    if (tarefa != null)
                    {
                        tarefa.Concluida = true;
                    }
                    break;
                case "4":
                    Console.Write("Digite a tarefa a ser excluída: ");
                    titulo = Console.ReadLine();
                    tarefa = tarefas.FirstOrDefault(t => t.Titulo == titulo);
                    if (tarefa != null)
                    {
                        tarefas.Remove(tarefa);
                    }
                    break;
            }
        }
    }
}

