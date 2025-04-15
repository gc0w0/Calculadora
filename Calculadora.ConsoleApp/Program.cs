using System;


namespace Calculadora.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----CALCULADORA----");

            Console.WriteLine("Digite a operação desejada -> (+, -, *, /) ou T para Tabuada ");
            var operacao = Console.ReadLine();

            if (operacao.ToUpper() == "T") // Coloquei aqui em cima para caso o usuario selecione a opção de Tabuada, ele não peça os outros valores.
            {
                Console.WriteLine("Digite o número para gerar a tabuada:");
                int tabuada = int.Parse(Console.ReadLine());

                int contador = 1;
                while (contador <= 10)
                {
                    Console.WriteLine($"{tabuada} x {contador} = {tabuada * contador}");
                    contador++;
                }
            }

            else if (operacao != "T"){

                Console.WriteLine("Digite o primeiro Valor: ");
                var primeiro_valor = double.Parse(Console.ReadLine());


                Console.WriteLine("Digite o segundo Valor: ");
                var segundo_valor = double.Parse(Console.ReadLine());

                if (operacao == "+")
                {
                    Console.WriteLine("Resultado: " + (primeiro_valor + segundo_valor));
                }
                else if (operacao == "-")
                {
                    Console.WriteLine("Resultado: " + (primeiro_valor - segundo_valor));
                }
                else if (operacao == "*")
                {
                    Console.WriteLine("Resultado: " + (primeiro_valor * segundo_valor));
                }
                else if (operacao == "/")
                {
                    if (segundo_valor != 0)
                    {
                        Console.WriteLine("Resultado: " + (primeiro_valor / segundo_valor));
                    }
                    else
                    {
                        Console.WriteLine("Erro: divisão por zero.");
                    }
                }

                else
                {
                    Console.WriteLine("Operação inválida.");
                }
            }


            



        }


    }
}
