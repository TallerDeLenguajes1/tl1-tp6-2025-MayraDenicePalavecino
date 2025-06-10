// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// 7.

int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
Console.WriteLine("valor de b:" + b);

//Ejercicio 1.

Console.WriteLine("Ingresar un numero: \n"); //muestra por pantalla
string? input = Console.ReadLine(); //leer una linea de texto que se puede obtener una cadena o por defecto null
int numero; //Aquí se guardará el número ingresado por el usuario una vez que haya sido validado y convertido. En este punto, no tiene un valor asignado explícitamente.

if (int.TryParse(input, out numero)) //TryParse devuelve un valor bool
{
    if (numero > 0)
    {
        int numeroInvertido = 0;
        int aux = numero;
        while (aux > 0)
        {
            int digito = aux % 10; // Obtiene el último dígito (ej: 123 % 10 = 3)
            numeroInvertido = (numeroInvertido * 10) + digito; // Construye el número invertido
            aux = aux / 10; // Elimina el último dígito (ej: 123 / 10 = 12)
        }

        Console.WriteLine($"Numero invertido: {numeroInvertido}"); // $"" Permite incrustar variables o expresiones directamente dentro de la cadena usando llaves {}
    } else
    {
        Console.WriteLine("El numero ingresado no es mayor que cero");
    }
}
else
{
    Console.WriteLine("El valor ingresado no es valido");
}








