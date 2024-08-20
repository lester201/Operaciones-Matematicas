using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Elige un operador: +, -, *, /");
        char operador = Console.ReadLine()[0];

        Console.WriteLine("Ingresa el primer número:");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double resultado = 0;

        if (operador == '+')
        {
            resultado = num1 + num2;
        }
        else if (operador == '-')
        {
            resultado = num1 - num2;
        }
        else if (operador == '*')
        {
            resultado = num1 * num2;
        }
        else if (operador == '/')
        {
            if (num2 != 0)
            {
                resultado = num1 / num2;
            }
            else
            {
                Console.WriteLine("División por cero no permitida.");
                return;
            }
        }
        else
        {
            Console.WriteLine("Operador no válido.");
            return;
        }

        Console.WriteLine($"El resultado es: {resultado}");
    }
}

