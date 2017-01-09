using System;

namespace Debugowanie
{
    class Program
    {
        public static void Main(string[] args)
        {
            int x = 1234;
            int y = Kwadrat(x);
            y = Kwadrat(y);
            string sy = y.ToString();
            Console.WriteLine(sy);
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
