public abstract class CuentaBancaria{
    protected double saldo;
    static public  void Menu()
    {
        Console.WriteLine("1. crear cuenta");
        Console.WriteLine("2. depositar");
        Console.WriteLine("3. extraer");
        Console.WriteLine("4. ver  saldo");
        Console.WriteLine("5. ver intereses");
        Console.WriteLine("6. salir");

    } 
    public void Extraer(double extraccion){
        if (extraccion <= this.saldo)
        {
            this.saldo -= extraccion;
        }
        else{
            Console.WriteLine("Saldo Insuficiente");
        }
    }
    public void Depositar(double monto){this.saldo += monto;} 
    public abstract void Interes();
    public double verSaldo(){return this.saldo;}
}

class CNormal : CuentaBancaria{
    public override void Interes()
    {
         Console.WriteLine($"Interés: {this.saldo * 0.01}");
    }
}
class CPremium : CuentaBancaria{
    public override void Interes()
    {
        Console.WriteLine($"Interés: {this.saldo * 0.1}");
    }
}

class prin{
     static void Main(string[] args)
    {
        CNormal cuenta1 = new CNormal();
        CPremium cuenta2 = new CPremium();
        double monto;
        Console.Write("Ingrese la cantidad a depositar en la cuenta normal: ");
        try{
            monto = Convert.ToDouble(Console.ReadLine());
        }catch(Exception E){
                Console.WriteLine("Ingrese un número: ");
        }monto = 0;
        cuenta1.Depositar(monto);
        Console.Write("Ingrese la cantidad a depositar en la cuenta premium: ");
        try{
            monto = Convert.ToDouble(Console.ReadLine());
        }catch(Exception E){
                Console.WriteLine("Ingrese un número: ");
        }monto = 0;
        cuenta2.Depositar(monto);
        Console.WriteLine("Saldo de la primera cuenta: " + cuenta1.verSaldo());
        Console.WriteLine("Saldo de la segunda cuenta: " + cuenta2.verSaldo());
        Console.Write("Ingrese la cantidad a extraer de la cuenta normal: ");
        try{
            monto = Convert.ToDouble(Console.ReadLine());
        }catch(Exception e){
                Console.WriteLine(e.Message);
        }monto = 0;
        cuenta1.Extraer(monto);
        Console.WriteLine("Saldo de la primera cuenta: " + cuenta1.verSaldo());
        Console.WriteLine("Saldo de la segunda cuenta: " + cuenta2.verSaldo());
        Console.Write("Cuenta normal "); 
        cuenta1.Interes();
        Console.Write("Cuenta premium "); 
        cuenta2.Interes();
    }
}