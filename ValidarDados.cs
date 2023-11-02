using System.Globalization;

namespace To_Do_List
{
    public class ValidarDados
    {
        public static int ValidarInt(string message)
        {
            int valor;
            int initialTop = Console.CursorTop; // Salva a posição inicial do cursor

            do
            {
                Console.SetCursorPosition(0, initialTop); // Restaura a posição original do cursor
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    break; // Sai do loop se a entrada for válida
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine("\nValor inválido. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);
                }
            } while (true);

            return valor;
        }
        public static DateOnly ValidarData(string message)
        {
            DateOnly date;
            int initialTop = Console.CursorTop;

            do
            {
                Console.SetCursorPosition(0, initialTop);
                Console.Write(message);

                if (DateOnly.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine("\nData inválida. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);
                }
            } while (true);

            return date;
        }

        public static string ValidarString(string message)
        {
            string? input;
            int initialTop = Console.CursorTop;

            do
            {
                Console.SetCursorPosition(0, initialTop);
                Console.Write(message);
                input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                else
                {
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.WriteLine("\nValor inválido. Pressione qualquer tecla para continuar.");
                    Console.ReadKey();
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write(new string(' ', Console.WindowWidth));
                    Console.SetCursorPosition(0, Console.CursorTop);
                }
            } while (true);

            return input;
        }
    }
}