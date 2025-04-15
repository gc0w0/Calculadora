using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ConsoleApp
{
    public class OperacaoBasica //que nem no video coloquei tudo como public pra que seja acessado de qualquer parte do código
    {
        //atributos
        public double primeiroNumero = 0; //input
        public double segundoNumero = 0; //input
        public char operador = '0'; //input

        public string mensagemErro = ""; //output
        public double resultado = 0; //output

        public bool CalcularValores() //que nem no video coloquei tudo como public pra que seja acessado de qualquer parte do código
        {
            bool conseguiuCalcular = true;

            if (operador == '+')            
                resultado = primeiroNumero + segundoNumero;
            
            else if (operador == '-')            
                resultado = primeiroNumero - segundoNumero;
            
            else if (operador == '*')            
                resultado = primeiroNumero * segundoNumero;
            
            else if (operador == '/')
            {
                if (segundoNumero == 0)
                {
                    mensagemErro = "Não é possível dividir por zero";
                    conseguiuCalcular = false;
                }
                else
                {
                    resultado = primeiroNumero / segundoNumero;
                }
            }

            return conseguiuCalcular;
        }

        public string ExibirTabuada(int numero) //que nem no video coloquei tudo como public pra que seja acessado de qualquer parte do código
        {            
            string tabuada = $"Tabuada do {numero}: " + "\n";

            for (int i = 1; i <= 10; i++)
            {
                tabuada += $"{numero} x {i} = {numero * i}" + "\n";
            }
            
            return tabuada;
        }


    }
}
