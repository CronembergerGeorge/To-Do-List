
using System.Net.WebSockets;

namespace To_Do_List
{
    class Program
    {
        public static void Main(string[] args)
        {
            ExecutaPrograma();
        }
        public static void ExecutaPrograma()
        {
            Tarefas tarefa = new();
            BasicMethods basic = new();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Escolha a opção desejada: ");
                Console.WriteLine($"1. Adicionar tarefa");
                Console.WriteLine($"2. Editar tarefa");
                Console.WriteLine($"3. Remover tarefa");
                Console.WriteLine($"4. Listar tarefas");
                Console.WriteLine($"5. Sair\n");

                int escolha = ValidarDados.ValidarInt("Digite o item desejado: ");
                try
                {
                    switch (escolha)
                    {
                        case 1:
                            tarefa.Dados();
                            Console.WriteLine("\nItem adicionado com sucesso!");
                            basic.TeclaVoltar();
                            break;
                        case 2:
                            tarefa.VisualisarLista();
                            int indice = ValidarDados.ValidarInt("Digite o indice do item que deseja remover: ");
                            if (indice >= 1 && indice <= Tarefas.listaTarefas.Count)
                            {
                                Tarefas.EditarTarefa(indice);
                                Console.WriteLine($"Item {indice} editado com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Índice inválido. Nenhuma tarefa removida");
                            }
                            basic.TeclaVoltar();
                            break;
                        case 3:
                            tarefa.VisualisarLista();
                            int indice2 = ValidarDados.ValidarInt("Digite o indice do item que deseja remover: ");
                            if (indice2 >= 1 && indice2 <= Tarefas.listaTarefas.Count)
                            {
                                Tarefas.RemoverTarefa(indice2);
                                Console.WriteLine($"Item {indice2} removido com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Índice inválido. Nenhuma tarefa removida");
                            }
                            basic.TeclaVoltar();
                            break;
                        case 4:
                            tarefa.VisualisarLista();
                            basic.TeclaVoltar();
                            break;
                        case 5:
                            basic.Sair();
                            break;
                        default:
                            Console.WriteLine("Escolha uma opção entre 1 e 4");
                            basic.TeclaVoltar();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Erro: {e.Message}");
                    ExecutaPrograma();
                }
            }
        }
    }
}
