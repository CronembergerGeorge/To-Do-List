using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace To_Do_List
{
    public class BasicMethods
    {
        public void TeclaVoltar()
        {
            Console.WriteLine($"\nPressione qualquer tecla para voltar ao menu principal");
            Console.ReadKey();
        }
        public void Sair()
        {
            Console.WriteLine("Programa encerrado. Pressione qualquer tecla para sair.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}