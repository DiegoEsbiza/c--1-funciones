namespace guia_funciones_1;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “producto” que reciba dos números enteros y que
        // devuelva el producto de ambos. Luego hacer un programa que pida el precio
        // de un artículo y la cantidad vendida y muestre por pantalla el monto total a
        // pagar. Usar la función.

        int precio, cantidad, resultado;

        Console.WriteLine("Ingrese el precio del articulo: ");
        precio = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese la cantidad vendida: ");
        cantidad = int.Parse(Console.ReadLine());

        resultado = producto(precio, cantidad);

        Console.WriteLine("El monto a abonar es: $" + resultado);

    }

    static int producto(int a, int b){
        int r
        r = a * b;
        return r;
    }
}
