using System;
public delegate void Callback(string name); //Creando Delegado tipo void que recibe por parametro un string
public class Program
{
    public static void Main(string[] args)
    {
        string nombre = "Amigo";
        if (args.Length > 0) 
        {
            nombre = args[0]; //args son los argumentos que se pasan por consola. EJ: dotnet run Peter
        }
        Callback cb = new Callback(diHola); //creamos el delegado cb y le asignamos la referencia al metodo diHola.
        // Callback cb = diHola; <--- hace lo mismo que la linea de arriba
        //cb(nombre); //le pasamos por parametro un string, y el delegado se lo pasara al metodo diHola
        cb += diChau;
        cb (nombre); //lo llamo de nuevo para que me muestre los dos métodos

        cb -= diHola; // así como se suman métodos, se pueden quitar
        Console.WriteLine("Luego de quitar uno de los métodos");
        cb(nombre);
    }
    private static void diHola(string nombre) // notese que diHola es void y tiene un parametro como lo requiere el delegado
    {
        Console.WriteLine("Hola, {0}", nombre);
    }
    private static void diChau(string nombre) 
    {
        Console.WriteLine("Chau, {0}. Que te vaya bien!!!", nombre);
    }
}