namespace guia_funciones_6;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función que se llame “sumaResta” que reciba dos números y que
        // devuelva la suma Y la resta del primer número con el segundo.
        // Nota: recordemos que una función solo puede devolver UN valor por return.
        // Cómo podríamos hacer para tener ambos resultados en el main?

        int a, b, suma = 0, resta = 0;

        Console.WriteLine("Ingrese un número: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        b = int.Parse(Console.ReadLine());

        sumaResta(a, b, ref suma, ref resta);

        Console.WriteLine("El resultado de la suma de los números es: " + suma);
        Console.WriteLine("El resultado de la resta de los números es: " + resta);
    }

    static void sumaResta(int a, int b, ref int suma, ref int resta){
        suma = a + b;
        resta = a - b;
    }
}
