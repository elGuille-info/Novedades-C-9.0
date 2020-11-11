//# ejemplo 1

//using System;

//namespace novedadescs9_02
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Console.WriteLine("Hello World!");
//            var persona1 = new Persona("Guillermo", 63);
//            Console.WriteLine(persona1);

//            var personaje1 = new Personaje("Guille", 63, 1996);
//            Console.WriteLine(personaje1);
//        }

//        public record Persona (string Nombre, int Edad);
//        public record Personaje (string Nombre, int Edad, int Desde) : Persona (Nombre, Edad);
//    }
//}


//# ejemplo 2

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine(persona1);

//var persona2 = new Persona2("Guillermo", 63);
//Console.WriteLine(persona2);

//public record Persona(string Nombre, int Edad);

//public record Persona2(string Nombre, int Edad)
//{
//    public override string ToString()
//    {
//        return $"{Nombre} nació en {DateTime.Now.Year - Edad}";
//    }
//}


//# ejemplo 3

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine(persona1);

//var persona2 = new Persona2("Guillermo", 63);
//Console.WriteLine(persona2);

//public record Persona(string Nombre, int Edad);

//public record Persona2(string Nombre, int Edad) : Persona (Nombre, Edad)
//{
//    public override string ToString()
//    {
//        return $"{Nombre} nació en {DateTime.Now.Year - Edad}";
//    }
//}


// # ejemplo 4

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine(persona1);

//var persona2 = new Persona2("Guillermo", 63);
//Console.WriteLine(persona2);

//var personaje1 = new Personaje("Guille", 63, 1996);
//Console.WriteLine(personaje1);

//public record Persona(string Nombre, int Edad);

//public record Persona2(string Nombre, int Edad) : Persona(Nombre, Edad)
//{
//    public override string ToString()
//    {
//        return $"{Nombre} nació en {DateTime.Now.Year - Edad}";
//    }
//}

//public record Personaje(string Nombre, int Edad, int Desde) : Persona(Nombre, Edad)
//{
//    public override string ToString()
//    {
//        return $"{Nombre} nació en {DateTime.Now.Year - Edad} y está activo desde {Desde}.";
//    }
//}


// # ejemplo 5

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine(persona1);

//var persona2 = new Persona2("Guillermo", 63);
//Console.WriteLine(persona2);

//var personaje1 = new Personaje("Guille", 63, 1996);
//Console.WriteLine(personaje1);

//public record Persona(string Nombre, int Edad);

//public record Persona2(string Nombre, int Edad) : Persona(Nombre, Edad)
//{
//    public override string ToString()
//    {
//        return $"{Nombre} nació en {DateTime.Now.Year - Edad}";
//    }
//}

//public record Personaje(string Nombre, int Edad, int Desde) 
//                        : Persona(Nombre, Edad);


// # ejemplo 6

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine(persona1);
//persona1.Edad = 64;
//Console.WriteLine(persona1);

//public record Persona(string Nombre, int Edad);

// Error CS8852: Init-only property or indexer 'Pers/ona.Edad' can only be assigned in an object initializer, or on 'this' or 'base' in an instance constructor or an 'init' accessor.


// # ejemplo 7

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine(persona1);
//// Esto da error de compilación
//// persona1.Edad = 64;

//var persona2 = persona1 with { Edad = 64 };

//Console.WriteLine("La persona2: {0}.",persona2);

//public record Persona(string Nombre, int Edad);


// # ejemplo 8

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine("La persona1: {0}.", persona1);

//var persona2 = new Persona("Guillermo", 63);
//Console.WriteLine("La persona2: {0}.", persona2);

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//public record Persona(string Nombre, int Edad);


// # ejemplo 9

//using System;

//var persona1 = new Persona("Guillermo", 63);
//Console.WriteLine("La persona1: {0}.", persona1);

//var persona2 = new Persona("Guillermo", 63);
//Console.WriteLine("La persona2: {0}.", persona2);

//var iguales = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales);

//public record Persona(string Nombre, int Edad);


// # ejemplo 10

// using System;

// var persona1 = new Persona("Guillermo", 63);
// Console.WriteLine("La persona1: {0}.", persona1);

// var persona2 = persona1 with { Edad = 64 };
// Console.WriteLine("La persona2: {0}.", persona2);

// var iguales = persona1.Equals(persona2);
// Console.WriteLine("persona1.Equals(persona2) es {0}", iguales);

// public record Persona(string Nombre, int Edad);


// # ejemplo 11

using System;

var persona = new Persona("Guillermo", 63);
Console.WriteLine("La persona: {0}.", persona);

var (n, e) = persona;
Console.WriteLine($"{n} {e}");


public record Persona(string Nombre, int Edad);
