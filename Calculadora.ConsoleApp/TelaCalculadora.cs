using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    internal class TelaCalculadora
    {
        internal bool continuar;
        public char operadorSelecionado;

        internal void ApresentarMenu()
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

            operadorSelecionado = ObtemOperador(Console.ReadLine());

            if (operadorSelecionado == '0')
            {
                Console.WriteLine("Opção inválida! Pressione qualquer tecla para voltar.");
                Console.ReadKey();                
            }
        }

        private static char ObtemOperador(string opcao)
        {
            if (opcao == "1") return '+';

            else if (opcao == "2") return '-';

            else if (opcao == "3") return '*';

            else if (opcao == "4") return '/';

            else if (opcao == "5") return 'T';

            return '0';
        }
    }
}
