namespace Cuenta.Core;
public class Cuenta : Dinero
{
    private static int _contador;
    public double Saldo { get; private set; }
    public int CBU { get; private set; }
    public Cuenta() => Saldo = 0;
    public double Monto { get; private set; }
}

public Persona(double saldo, double Monto)
        {
            CBU = ++_contador;
            Saldo = saldo;
            Monto = monto;
        } 

public void Debitar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");

            if (monto > Saldo)
                throw new InvalidOperationException("El monto supera el saldo.");
            Saldo -= monto;
        }
public void Acreditar(double monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto tiene que ser mayor a cero.");
            Saldo += monto;
        }