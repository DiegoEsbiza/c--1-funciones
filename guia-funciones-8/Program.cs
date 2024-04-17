namespace guia_funciones_8;

class Program
{
    static void Main(string[] args)
    {
        // Hacer un programa que permita ingresar una lista de números que corta
        // cuando se ingresa un cero. A partir de dichos datos informar:
        // a. El mayor de los números pares.
        // b. La cantidad de números impares.
        // c. El menor de los números primos.
        // Hacer uso de las funciones anteriormente desarrolladas.

        int n, npar, maxpar = 0, contImpar = 0, nprimo, minprimo = 0;
        bool bpar = false, bprimo = false;

        Console.WriteLine("Ingrese un número: ");
        n = int.Parse(Console.ReadLine());

        while (n != 0)
        {
            npar = par(n);

            if(npar == 1){
                if (!bpar)
                {
                    maxpar = n;
                    bpar = true;
                }else if (n > maxpar)
                {
                    maxpar = n;
                }
                
            }else{
                contImpar++;
            }

            nprimo = primo(n);

            if(nprimo == 1){
                if(!bprimo){
                    minprimo = n;
                    bprimo = true;
                }else if (n < minprimo)
                {
                    minprimo = n;
                }

            }

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("El mayor número par ingresado es: " + maxpar);
        Console.WriteLine("Se ingresaron " + contImpar + " números impares");
        Console.WriteLine("El menor número primo ingresado fue: " + minprimo);
    }

    static int par(int n){
        int r;

        if (n % 2 == 0)
        {
            r = 1;
        }else{
            r = 0;
        }

        return r;
    }

    static int primo (int n){
        int r, cont = 0;

        for (int x = 1; x < n; x++)
        {
            if (n % x == 0)
            {
                cont++;
            }
            
        }

        if(cont == 1){
            r = 1;
        }else{
            r = 0;
        }

        return r;
    }
}
