namespace guia_funciones_2;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “mayor” que reciba dos números enteros y
        // devuelva el mayor de ellos o cero si son iguales.
        int a, b, resultado;

        Console.WriteLine("Ingrese un número: ");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número: ");
        b = int.Parse(Console.ReadLine());

        resultado = mayor(a, b);

        if (resultado != 0)
        {
            Console.WriteLine("El número mayor es: " + resultado);
        }else
        {
            Console.WriteLine("El resultado es: " + resultado);
        }

    }

    static int mayor(int a, int b){
        int r;
        if (a > b)
        {
            r = a;
        }else if(a < b)
        {
            r = b;
        }else{
            r = 0;
        }

        return r;
    }
}
