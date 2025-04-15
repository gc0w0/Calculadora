using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    public class operacoes //que nem no video coloquei tudo como public pra que seja acessado de qualquer parte do código
    { 
    {
        public static void operacoesBasicas(char operador) //que nem no video coloquei tudo como public pra que seja acessado de qualquer parte do código
        {
            Console.Clear();
            Console.Write("Digite o primeiro Valor: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo Valor: ");
            double num2 = double.Parse(Console.ReadLine());

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
                if (num2 == 0)
                {
                    Console.WriteLine("Não é possível dividir por zero");
                    Console.ReadKey();
                    return;
                }
                resultado = num1 / num2;
            }

            Console.WriteLine($"Resultado: {resultado}");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }

        public static void Tabuada() //que nem no video coloquei tudo como public pra que seja acessado de qualquer parte do código
        {
            Console.Clear();
            Console.Write("Digite o Valor para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nTabuada do {numero}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }

            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
            Console.ReadKey();
        }


    }
}
