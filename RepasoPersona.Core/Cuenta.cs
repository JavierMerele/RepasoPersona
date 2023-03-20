using System;

namespace RepasoPersona.Core;
public class Cuenta : Dinero
{
    private static int _contador;
    public int CBU { get; private set; }
    public Cuenta() => Saldo = 0;

    public Cuenta(double saldo, double monto, int cbu) : base(saldo, monto)
    {
        CBU = ++_contador;
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
}
