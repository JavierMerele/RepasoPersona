namespace Dinero.Core;
public abstract class Dinero
{
    public double Monto { get; protected set; }
}

public Dinero(double Monto)
        {
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
