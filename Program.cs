using System;

namespace Ejemplo004___TiposDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int emplea {sizeof(int)} bytes y puede almacenar números desde {int.MinValue:N0} a {int.MaxValue:N0}.");
            Console.WriteLine($"double emplea {sizeof(double)} bytes y puede almacenar números desde {double.MinValue:N0} a {double. MaxValue:N0}.");
            Console.WriteLine($"decimal emplea {sizeof(decimal)} bytes y puede almacenar números desde {decimal.MinValue:N0} a {decimal.MaxValue:N0}.");
        }
    }
}
