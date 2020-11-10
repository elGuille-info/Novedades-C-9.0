//# ejemplo 1

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };

//class Persona
//{ 
//    public string Nombre { get; init; }
//    public int Edad { get; init; }
//}


//# ejemplo 2

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//Console.WriteLine(persona1);

//persona1.Nombre = "Guille";
//Console.WriteLine(persona1);

//record Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 3

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//persona1.Nombre = "Guille";

//Console.WriteLine(persona1);

//var persona2 = new Persona { Nombre = "Guille", Edad = 63 };

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//record Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 4

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//persona1.Nombre = "Guille";

//Console.WriteLine(persona1);

//var persona2 = new Persona { Nombre = "Guille", Edad = 63 };

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//var iguales2 = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales2);

//class Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 5

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//persona1.Nombre = "Guille";

//Console.WriteLine(persona1);

//var persona2 = persona1;

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//var iguales2 = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales2);

//class Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 6

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//persona1.Nombre = "Guille";

//Console.WriteLine(persona1);

//var persona2 = persona1;

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//var iguales2 = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales2);

//Console.WriteLine("Antes de la nueva asignación");
//Console.WriteLine(persona1.Nombre);
//Console.WriteLine(persona2.Nombre);

//persona1.Nombre = "Guillermo";

//Console.WriteLine("Después de la nueva asignación");
//Console.WriteLine(persona1.Nombre);
//Console.WriteLine(persona2.Nombre);

//class Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 7

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//persona1.Nombre = "Guille";

//Console.WriteLine(persona1);

//var persona2 = persona1;

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//var iguales2 = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales2);

//Console.WriteLine("Antes de la nueva asignación");
//Console.WriteLine(persona1.Nombre);
//Console.WriteLine(persona2.Nombre);

//persona1.Nombre = "Guillermo";

//Console.WriteLine("Después de la nueva asignación");
//Console.WriteLine(persona1.Nombre);
//Console.WriteLine(persona2.Nombre);

//record Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 8

//using System;

//var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
//persona1.Nombre = "Guille";

//Console.WriteLine(persona1);

//var persona2 = persona1 with { Nombre = "Guille" };

//var iguales = persona1 == persona2;
//Console.WriteLine("persona1 == persona2 es {0}", iguales);

//var iguales2 = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales2);

//Console.WriteLine("Antes de la nueva asignación");
//Console.WriteLine(persona1.Nombre);
//Console.WriteLine(persona2.Nombre);
//iguales = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales);

//persona1.Nombre = "Guillermo";

//Console.WriteLine("Después de la nueva asignación");
//Console.WriteLine(persona1.Nombre);
//Console.WriteLine(persona2.Nombre);
//iguales = persona1.Equals(persona2);
//Console.WriteLine("persona1.Equals(persona2) es {0}", iguales);

//record Persona
//{
//    public string Nombre { get; set; }
//    public int Edad { get; init; }
//}


//# ejemplo 9

using System;

var persona1 = new Persona { Nombre = "Guillermo", Edad = 63 };
persona1.Nombre = "Guille";

Console.WriteLine(persona1);

// esta asignación solo se puede hacer con record no con class
var persona2 = persona1 with { Nombre = "Guille" };
// el error es:
// Error CS8858 The receiver type 'Persona' is not a valid record type.


var iguales = persona1 == persona2;
Console.WriteLine("persona1 == persona2 es {0}", iguales);

var iguales2 = persona1.Equals(persona2);
Console.WriteLine("persona1.Equals(persona2) es {0}", iguales2);

Console.WriteLine("Antes de la nueva asignación");
Console.WriteLine(persona1.Nombre);
Console.WriteLine(persona2.Nombre);

persona1.Nombre = "Guillermo";

Console.WriteLine("Después de la nueva asignación");
Console.WriteLine(persona1.Nombre);
Console.WriteLine(persona2.Nombre);

class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; init; }
}
