using System;
using System.Timers;
using System.Threading;
internal class Program
{

    private static void Main(string[] args)
    {
        Reloj c1 = new Reloj(3);
        Reloj c2 = new Reloj(1);
        Console.WriteLine("Reloj en funcionamiento, usar Ctrl - c para acabar");
        while (true) Thread.Sleep(500); //Thread hace referencia al hilo del CPU que esta ejecutando nuestro codigo.
    }
}


public class Reloj
{
    private int intervalo;
    private int totalTiempo;
    public Reloj(int intervalo) //constructor
    {
        this.totalTiempo = 0;
        this.intervalo = intervalo;

        System.Timers.Timer timer = new System.Timers.Timer(); // Creando timer
        ElapsedEventHandler tickHandler = new ElapsedEventHandler(Tic); //Delegado que controla el evento Elapsed de Timer (Ver documentación)
        timer.Elapsed += tickHandler; //evento Elapsed de timer, le agregamos el delegado tickHander, entonces cada vez que timer emita el evento elapsed, el delegado ejecutara Tic
        timer.Interval = intervalo * 1000; // milisegundos
        timer.Enabled = true;  // true para que timer genere el evento
    }
    public void Tic(object source, ElapsedEventArgs e)
    {
        this.totalTiempo += this.intervalo;
        Console.WriteLine("{0}: {1} segundo tic, tiempo pasado: {2} Ahora es: {3}", source, this.intervalo, this.totalTiempo, e.SignalTime);
    }
}
