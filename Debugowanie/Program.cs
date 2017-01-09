using System;

namespace Debugowanie
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int x = 1234;
                int y = Kwadrat(x);
                y = Kwadrat(y);
                string sy = y.ToString();
                Console.WriteLine(sy);
            }
            catch (Exception ex)
            {
                ConsoleColor currentColor = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Error.WriteLine("Błąd: {0}", ex.Message);
                Console.ForegroundColor = currentColor;

            }
        }

        private static int Kwadrat(int argument)
        {
            var value = argument*argument;
            if(value < 0)
                throw new Exception("Funckja kwadrat nie powinna zwracać wartości ujemnej!");
            return value;
        }
    }
}
