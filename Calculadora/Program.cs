using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Operacoes> filaOperacoes = new Queue<Operacoes>();
            filaOperacoes.Enqueue(new Operacoes { valorA = 2, valorB = 3, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 14, valorB = 8, operador = '-' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 5, valorB = 6, operador = '*' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 2147483647, valorB = 2, operador = '+' });
            filaOperacoes.Enqueue(new Operacoes { valorA = 18, valorB = 3, operador = '/' });

            Calculadora calculadora = new Calculadora();
            List<Operacoes> todasOperacoes = new List<Operacoes>();
            Stack<decimal> pilhaResultados = new Stack<decimal>();
            
            foreach (var op in filaOperacoes)
            {
                todasOperacoes.Add(op);
            }

            
            while (filaOperacoes.Count > 0)
            {
                //Removendo e lendo o primeiro item da fila.
                Operacoes operacao = filaOperacoes.Dequeue();
                calculadora.calcular(operacao);
                
                pilhaResultados.Push(operacao.resultado);
                
                Console.WriteLine("{0} {1} {2} = {3}", operacao.valorA,operacao.operador,operacao.valorB, operacao.resultado);
                
                PrintProximasOperacoes(filaOperacoes);
                Console.WriteLine();                
            }

            //Print dos resultados.
            foreach (decimal resultado in pilhaResultados.Reverse())
            {
                Console.WriteLine(resultado);
            }
            
        }

        static void PrintProximasOperacoes(Queue<Operacoes> filaOperacoes)
        {
            Console.WriteLine();
            int contador = 1;
            foreach (Operacoes op in filaOperacoes)
            {
                Console.WriteLine("{0}. {1} {2} {3}", 
                    contador, op.valorA, op.operador, op.valorB);
                contador++;
            }

        }

    }
}
