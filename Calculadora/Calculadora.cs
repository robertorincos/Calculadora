using System;
using System.Runtime.CompilerServices;
namespace Calculadora
{
    public class Calculadora
    {
        
        public Operacoes calcular(Operacoes operacao)
        {
            switch(operacao.operador)
            {
                case '+': operacao.resultado= soma(operacao);break;
                case '-': operacao.resultado = subtracao(operacao);break;
                case '*': operacao.resultado = multiplicacao(operacao);break;
                case '/': operacao.resultado = divisao(operacao);break;
                default: operacao.resultado = 0; break;
            }
            return operacao;
        }
        public decimal soma(Operacoes operacao)
        {
            return (decimal)operacao.valorA + (decimal)operacao.valorB;
        }
        public int subtracao(Operacoes operacao)
        {
            return operacao.valorA - operacao.valorB;
        }
        public int multiplicacao(Operacoes operacao)
        {
            return operacao.valorA * operacao.valorB;
        }
        public int divisao(Operacoes operacao)
        {
            if (operacao.valorB == 0)
            {
                Console.WriteLine("Detectado divisão por zero");
                Environment.Exit(1);
            }
            return operacao.valorA / operacao.valorB;
        }
    }
}
