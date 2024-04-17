namespace guia_funciones_7;

class Program
{
    static void Main(string[] args)
    {
        // Hacer una función de tipo void (porque no va a devolver nada) llamada
        // “positivoNegativoCero” que reciba un número por valor y una variable por
        // referencia. Que analice el número y escriba variable recibida por referencia
        // con:
        // a. 1 si el número es positivo.
        // b. -1 si el número es negativo.
        // c. 0 si el número es cero.

        int n, tipo = 0, contPositivo = 0, contNegativo = 0, contCero = 0;

        for (int x = 0; x < 100; x++)
        {
            Console.WriteLine("Ingrese un número");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n, ref tipo);

            if(tipo == 1){
                contPositivo++;
            }else if (tipo == -1)
            {
                contNegativo++;
            }else{
                contCero++;
            }            
        }

        Console.WriteLine("Se ingresaron: ");
        Console.WriteLine(contPositivo + " números positivos");
        Console.WriteLine(contNegativo + " números negativos");
        Console.WriteLine(contCero + " veces el número cero");
    }

    static void positivoNegativoCero(int n, ref int tipo){
        if (n > 0)
        {
            tipo = 1;
        }else if (n == 0)
        {
            tipo = 0;
        }else
        {
            tipo = -1;
        }
    }
}
