namespace guia_funciones_4;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función llamada “primo” que reciba un número entero y devuelva 1
        // si el número es primo o cero si no lo es. Hacer un programa para ingresar
        // números. El lote corta cuando se ingresa un número cero. Informar el
        // promedio teniendo en cuenta sólo los números primos.

        int n, acu = 0, cont = 0, prom;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            if (primo(n))
            {
                acu += n;
                cont++;
            }
            
            Console.WriteLine("ingrese otro número o 0 para finalizar");
            n = int.Parse(Console.ReadLine());
        }

        prom = acu/cont;

        Console.WriteLine("El promedio de los números primos ingresados es: " + prom);
        Console.WriteLine("Fin del programa");
    }

    static bool primo(int n){
        int cont = 0;
        for (int x = 1; x < n; x++)
        {
            if(n % x == 0){
                cont++;
            }            
        }

        if(cont == 1){
            return true;
        }else{
            return false;
        }
    }
}
