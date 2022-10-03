using System.Collections.Generic;
internal class Program
{
    private static void Main(string[] args)
    {
		//a continuación vamos a filtrar una lista y enviarles un email a todos los mayores de 18 años
        //primero lo vamos a hacer un con delegado predicado
        //más abajo lo vamos a realizar con expresiones lambdas


        List<Persona> Personas = new List<Persona>(); //Creando la lista Personas
        Personas.Add(new Persona { edad = 21, nombre = "julio", empleo = true }); //Cargando Personas en la lista
        Personas.Add(new Persona { edad = 17, nombre = "Maria", empleo = false });
        Personas.Add(new Persona { edad = 25, nombre = "Omar", empleo = false });
        Personas.Add(new Persona { edad = 15, nombre = "julia", empleo = true });
        Personas.Add(new Persona { edad = 21, nombre = "Caro", empleo = true });

        List<Persona> ClientesPotenciales; //Creamos una nueva lista para guardar Personas mayores a 18, por ahora vacía

        //creando un predicado
        Predicate<Persona> Mayor18 = new Predicate<Persona>(EsMayorDe18); //el predicado apunta al metodo EsMayorDe18 (el método debe ser booleano)


        ClientesPotenciales = Personas.FindAll(Mayor18);//utilizamos el predicado en el método FindAll que nos devuelve(se guardan en ClientesPotenciales) todos aquellos que cumplen con la expresión
		
        Console.WriteLine("Mayores de 18");
        foreach (var persona in ClientesPotenciales) //vamos a comprobar si filtro bien 
        {
            System.Console.WriteLine(persona.nombre);
        }

        foreach (Persona persona in ClientesPotenciales)
        { 
            EnviarEmail(persona);//enviando los emails
        }

        Predicate<Persona> PoteCliente = new Predicate<Persona>(PotencialCliente); //el predicado apunta al metodo PotencialCliente (el método debe ser booleano)


        ClientesPotenciales = Personas.FindAll(PoteCliente);//utilizamos el predicado en el método FindAll que nos devuelve(se guardan en ClientesPotenciales) todos aquellos que cumplen con la expresión
		
        Console.WriteLine("Mayores de 18 con trabajo");
        foreach (var persona in ClientesPotenciales) //vamos a comprobar si filtro bien 
        {
            System.Console.WriteLine(persona.nombre);
        }

        foreach (Persona persona in ClientesPotenciales)
        { 
            EnviarEmail(persona);//enviando los emails
        }


        static bool EsMayorDe18(Persona p)
        {
            return p.edad >= 18;
        }
        static bool PotencialCliente(Persona p)
        {
            return (p.edad >= 18 && p.empleo == true);
        }

        static void EnviarEmail(Persona p)
        {
            System.Console.WriteLine("email enviado a: " + p.nombre);
        }


        Console.WriteLine("Usando lambdas");
        //  Utilizando lambdas
        ClientesPotenciales = Personas.FindAll(x => x.edad >= 18); //Utilizamos la expresion lambda en el metodo Personas.FindAll(que nos devuelte todos aquellos que cumplen con la expresion)

       /* foreach (Persona cliente in ClientesPotenciales)
        {
            System.Console.WriteLine("Cliente {0} edad: {1}", cliente.nombre, cliente.edad);
        }*/
        ClientesPotenciales.ForEach(cliente => System.Console.WriteLine("Cliente {0} edad: {1}", cliente.nombre, cliente.edad));

        ClientesPotenciales.ForEach(cli => EnviarEmail(cli)); //enviando un email a todos los posibles clientes
        
    }
}

public struct Persona
{
    public int edad { get; set; } // get y set de C# 
    public string nombre { get; set; }
    public bool empleo { get; set; }
}
