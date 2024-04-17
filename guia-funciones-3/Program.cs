namespace guia_funciones_3;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si
        // es par o cero si no lo es. Hacer un programa para ingresar 20 números y
        // mostrar por pantalla cuántos son pares.

        int n, resultado, contador = 0;

        for (int x = 0; x < 20; x++)
        {
            Console.WriteLine("ingrese un número");
            n = int.Parse(Console.ReadLine());

            if (par(n))
            {
                contador++;
            }
        }

        Console.WriteLine("De los 20 números ingresados " + contador + " son pares");
    }

    static bool par(int n){
        if (n % 2 == 0)
        {
            return true;
        }else{
            return false;
        }
    }
}
