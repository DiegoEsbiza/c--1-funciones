namespace guia_funciones_5;

class Program
{
    static void Main(string[] args)
    {
        //Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad
        //de pagos (entero) y devuelva el monto de cada cuota. Hacer un programa para
        //ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de cuotas.
        //El programa deberá mostrar la cantidad de cuotas y el monto de las mismas para
        //cada una de las ventas.

        float monto, total;
        int cuotas;

        for (int x = 0; x < 10; x++)
        {
            Console.WriteLine("Ingrese el monto del articulo: ");
            monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de cuotas a abonar: ");
            cuotas = int.Parse(Console.ReadLine());

            total = pagos(monto, cuotas);

            Console.WriteLine("El articulo se abonara en " + cuotas + " de $" + total);
        }

        Console.WriteLine("fin del programa");
    }

    static float pagos (float monto, int cuotas){
        float r;
        r = monto / cuotas;

        return r;
    }
}
