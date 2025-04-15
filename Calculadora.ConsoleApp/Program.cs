using System;


namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("----CALCULADORA----");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("0 - Sair");
                Console.Write("Opção: ");

                var opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    operacoesBasicas('+');
                }
                else if (opcao == "2")
                {
                    operacoesBasicas('-');
                }
                else if (opcao == "3")
                {
                    operacoesBasicas('*');
                }
                else if (opcao == "4")
                {
                    operacoesBasicas('/');
                }
                else if (opcao == "5")
                {
                    Tabuada();
                }
                else if (opcao == "0")
                {
                    continuar = false;
                }
                else
                {
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para voltar.");
                    Console.ReadKey();
                }
            }

            static void operacoesBasicas(char operador)
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

            static void Tabuada()
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
}
