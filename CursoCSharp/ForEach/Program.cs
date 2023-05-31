// See https://aka.ms/new-console-template for more information

using static System.Console; 

var persona = new Persona {
    Nombre = "Anderson",
    Apellido = "Mena",
    Edad = 35
};

List<Persona> listaPersonas = new();

listaPersonas.Add(persona);

persona = new Persona
{
    Nombre = "Juan",
    Apellido = "Gonzales",
    Edad = 48
};

listaPersonas.Add(persona);

foreach (var _persona in listaPersonas) { 
    WriteLine(_persona.Nombre);
    WriteLine(_persona.Apellido);
    WriteLine(_persona.Edad);
}

// Arrays
int[] arrayEnteros;
int[] arrayEnteros2 = new int[5];
int[] arrayEnteros3 = { 1, 2, 3, 4 };

// Matriz
int[,] arrayMatriz = new int[2, 2];
int[,] arrayMatriz2 = { { 2, 2 }, { 3, 6 } };
int[][] arrayMatrizMatriz = new int[6][];

public class Persona {
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public int? Edad { get; set; }

}
