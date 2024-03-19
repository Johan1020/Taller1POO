namespace Taller1POO
{
    internal class Punto1
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta(2000);
            Console.WriteLine("El saldo inicial es: " + cuenta.obtenerSaldo());

            cuenta.miembroCredit(1000);
            Console.WriteLine("Se agrego: " + cuenta.obtenerSaldo());

            cuenta.miembroCargar(1000);
            Console.WriteLine("Se retiro: " + cuenta.obtenerSaldo().ToString());

            cuenta.miembroCargar(3000);

            Console.WriteLine("El valor total es: " + cuenta.obtenerSaldo());
        }

        class Cuenta
        {
            public int saldo;

            public Cuenta(int saldoInicial)
            {
                if (saldoInicial >= 0)
                {
                    saldo = saldoInicial;
                }
                else
                {
                    saldo = 0;
                    Console.WriteLine("El saldo inicial es de: " + saldo);
                }
            }

            public void miembroCredit(int monto)
            {
                saldo += monto;
            }

            public void miembroCargar(int retirar)
            {
                if (retirar <= saldo)
                {
                    saldo -= retirar;
                }
                else
                {
                    Console.WriteLine("El monto a retirar se excede");
                }
            }

            public int obtenerSaldo()
            {
                return saldo;
            }
        }
    }
}
