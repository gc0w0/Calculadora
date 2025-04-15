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
                //todos os que tem "operacoes." ele esta puxando do outro arquivo.
                if (opcao == "1")
                {
                    operacoes.operacoesBasicas('+'); 
                }
                else if (opcao == "2")
                {
                    operacoes.operacoesBasicas('-');
                }
                else if (opcao == "3")
                {
                    operacoes.operacoesBasicas('*');
                }
                else if (opcao == "4")
                {
                    operacoes.operacoesBasicas('/');
                }
                else if (opcao == "5")
                {
                    operacoes.Tabuada();
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
        }


    }
}
