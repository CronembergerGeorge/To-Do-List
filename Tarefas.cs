using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do_List
{
    public class Tarefas
    {
        public string Descricao { get; set; }
        public DateOnly Date { get; set; }
        public static List<Tarefas> listaTarefas { get; set; } = new List<Tarefas>();
        public Tarefas()
        {
            Descricao = "";
            Date = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        }
        public Tarefas(string descricao, DateOnly date)
        {
            Descricao = descricao;
            Date = date;
        }
        public void Dados()
        {
            try
            {
                string descricaoTarefa = ValidarDados.ValidarString("Digite a descrição da tarefa: ");
                DateOnly date = ValidarDados.ValidarData("Digite a Data(DD/MM/AAAA): ");

                Tarefas tarefa = new Tarefas(descricaoTarefa, date);
                AdicionarTarefa(tarefa);

                Console.Write(descricaoTarefa + " - " + date);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Erro: {e.Message}");
            }
        }
        public void VisualisarLista()
        {
            int contador = 1;
            foreach (Tarefas tarefa in listaTarefas)
            {
                Console.WriteLine($"\n{contador} Descrição: {tarefa.Descricao}, Data: {tarefa.Date}");
                contador++;
            }
        }
        public void VisualisarTarefa()
        {
            int contador = 1;
            foreach (Tarefas tarefa in listaTarefas)
            {
                Console.WriteLine($"{contador} Descrição: {tarefa.Descricao}, Data: {tarefa.Date}");
                contador++;
            }
        }
        public static void AdicionarTarefa(Tarefas tarefa)
        {
            listaTarefas.Add(tarefa);
        }
        public static void RemoverTarefa(int indice)
        {
            if (indice >= 1 && indice <= listaTarefas.Count)
            {
                listaTarefas.RemoveAt(indice - 1);
            }
            else
            {
                Console.WriteLine($"Indice inváido.");
            }
        }
        public static void EditarTarefa(int indice)
        {
            if (indice >= 1 && indice <= listaTarefas.Count)
            {
                Tarefas tarefa = listaTarefas[indice - 1];
                Console.WriteLine($"1. Descrição: {tarefa.Descricao}");
                Console.WriteLine($"2. Data: {tarefa.Date}");
                int valorEscolhido = ValidarDados.ValidarInt("Selecione o item indice que deseja editar");

                if (valorEscolhido == 1)
                {
                    string novaDescricao = ValidarDados.ValidarString($"Nova descrição: ");
                    tarefa.Descricao = novaDescricao;
                }
                else if (valorEscolhido == 2)
                {
                    DateOnly newDate = ValidarDados.ValidarData($"Nova Data: ");
                    tarefa.Date = newDate;
                }
                else if (valorEscolhido == 0)
                {
                    Console.WriteLine("Edição cancelada");
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }
            }
            else
            {
                Console.WriteLine($"Indice inváido.");
            }
        }
    }
}