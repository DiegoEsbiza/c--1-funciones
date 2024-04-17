namespace funciones_explicacion;

class Program
{
    static void Main(string[] args)
    {
        /*Funciones: 
        
        Las funciones son bloques de codigo con un comienzo y un final (un "mini programa") destinados a "modularizar" un programa grande en distintos programas pequeños en el que cada parte resuelve un pequeño problema.
        
        Su estructura se conforma de la siguientes partes principales con sus respectivas "sub partes":

            *cabecera:

                1.- Tipo de dato (int, float, bool, char, etc).
                2.- Nombre, siguiendo las mismas reglas de las variables(No puede contener espacios, simbolos, arrancar con números ni ser palabras reservadas, etc ).
                3.- (Opcional) Parametros (Datos que se le pueden dar o no a la función para que trabaje). 
        
            *cuerpo:
                1.- Definición o Lógica (Algoritmo, instrucciones a realizar), va dentro de las llaves -> { }.
                2.- (Opcional) Retorno (devolucion de un valor [UNO solo]).

        A modo de ejemplo, se codificara una funcion sencilla.

        NOTA: Las funciones se codifican FUERA de las llaves del programa principal (MAIN).

        Para utilizar las funciones es necesario llamarlas / invocarlas. Se crearan fuera del MAIN pero se las invocara dentro.
        

        En el siguiente ejemplo, se hara nuevamente el primer programa nuevamente (sumar dos números) con una función, pasando los argumentos "por valor". Luego, se realizara otra función para pedir los datos correspondientes, pero esta vez, pasando argumentos "por referencia"

        int a, b;

        Console.WriteLine("Ingrese un número");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        b = int.Parse(Console.ReadLine());

        llamado de función

        int resultado = sumar(a, b); //los datos pasados son "argumentos" (NO confundir con parametros). NO se declara tipo de datos (ni tamaño en el caso de los vectores, estos solo podran pasarse por referencia)
        Console.WriteLine("El resultado es: " + resultado);

        En el ejemplo anterior, la función recibio los argumentos por valor (realizando una copia momentanea de ambos números en dos espacios de memoria nuevos, de manera que, durante la ejecución de la función existiran 4 variables, en dos de ellas se guardaran los valores pedidos originalmente y en las otras dos se guardaran copias de las mismas que seran destruidas luego de retornar el valor correspondiente)

        ==========================================================================================================
        
        Paso de valores por referencia:
        
        para pasar los valores por referencia basta con simplemente hacer uso de la palabra reservada "ref" en los argumentos/parametros y declarando la función como tipo "void" (esta no admite el uso del "return" ya que no devuelve dato alguno)*/

        int n1 = 0, n2 = 0, resultado;

        pedirDatos(ref n1, ref n2);

        resultado = sumar(n1, n2);

        Console.WriteLine("El resultado es: " + resultado);


    }

    /*Las funciones se DEBEN codificar FUERA de las llaves del MAIN, es una función aparte.
    esta función devolvera el valor 1 (uno)

    declaración de la función (con paso de parametros "por valor"):

    cabecera*/
    static int sumar(int a, int b){ //entre parentesis, los datos recibidos son "parametros" (NO confundir con argumentos) es necesario declarar el tipo de dato a recibir, y el tamaño si de vectores se tratase (unicamente se recibiran por referencia)
        //cuerpo de la funcion
        int r = a + b;
        return r;
    }

    //Paso de parametros "por referencia"

    static void pedirDatos(ref int a, ref int b){
        Console.WriteLine("Ingrese un número");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese otro número");
        b = int.Parse(Console.ReadLine());
    }
}
