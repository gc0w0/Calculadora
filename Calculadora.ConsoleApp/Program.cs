using System;


namespace Calculadora.ConsoleApp
{
    //public class Funcionario
    //{
    //    public static int contador = 0;

    //    public int id = 0;
    //    public decimal Salario = 0;

    //    public Funcionario()
    //    {
    //        contador++;
    //        id = contador;
    //    }
    //}

    public class Program
    {
        static void Main(string[] args)
        {
            #region exemplo instancias de objetos e variáveis globais (variáveis estáticas)
            //Funcionario f1 = new Funcionario();
            //f1.Salario = 2000;

            //Funcionario f2 = new Funcionario();
            //f2.Salario = 3000;

            //Funcionario f3 = new Funcionario();
            //f3.Salario = 4000;
            #endregion
            
            TelaCalculadora telaCalculadora = new TelaCalculadora();    

            while (telaCalculadora.continuar)
            {
                telaCalculadora.ApresentarMenu();
                              
                OperacaoBasica operacao = new OperacaoBasica();
                operacao.operador = telaCalculadora.operadorSelecionado; //input 

                if (telaCalculadora.operadorSelecionado == 'T')
                {
                    Console.Clear();
                    Console.Write("Digite o Valor para ver a tabuada: ");
                    int numero = int.Parse(Console.ReadLine());
                    operacao.ExibirTabuada(numero);

                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
                    Console.ReadKey();
                }

                Console.Clear();

                Console.Write("Digite o primeiro Valor: ");
                operacao.primeiroNumero = double.Parse(Console.ReadLine()); //input 

                Console.Write("Digite o segundo Valor: ");
                operacao.segundoNumero = double.Parse(Console.ReadLine()); //input 

                var conseguiuCalcular = operacao.CalcularValores(); // processamento

                if (conseguiuCalcular == false)
                    Console.WriteLine(operacao.mensagemErro); //output

                Console.WriteLine($"Resultado: {operacao.resultado}"); //output
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu.");
                Console.ReadKey();
            }
        }       
    }
}
