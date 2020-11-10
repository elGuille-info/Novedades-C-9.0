//# ejemplo 1

//using System;

//namespace novedadescs9_01
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//        }
//    }
//}

//# ejemplo 2

//using System;

//Console.WriteLine("Hello World!");

//# ejemplo 3

//using System;

//Console.WriteLine("¡Hola {0}!", args[0]);


//# ejemplo 4

//using System;

//if (args.Length == 0 || string.IsNullOrEmpty(args[0]) )
//    return 1;

//Console.WriteLine("¡Hola {0}!", args[0]);

//return 0;

//# ejemplo 5

using System;

if (args.Length == 0 || string.IsNullOrEmpty(args[0]))
{
    Console.WriteLine("Debes escribir un nombre.");
    return 1;
}

Console.WriteLine("¡Hola {0}!", args[0]);

return 0;

