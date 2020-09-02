using RegraNegocio_Strategy.Entities;
using RegraNegocio_Strategy.Entities.ClassesConcretas;
using RegraNegocio_Strategy.Enum;
using RegraNegocio_Strategy.Factory;
using System;

namespace EstudoStrategy_II
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Write("Olá Informe o primeiro valor: ");
            var v1 = double.Parse(Console.ReadLine());
            Console.Write("Informe o segundo valor: ");
            var v2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual é o tipo de operação.:");
            Console.Write("Soma = ( 1 ); Subtração = ( 2 ); Divisão ( 3 );  Multiplicação = ( 4 ) .:  ");
            var operacao = Enum.Parse<enumOperacoes>(Console.ReadLine());
            CalcularFactory calculadora  = new CalcularFactory();
            Console.WriteLine(calculadora.OperacaoEscolhida(operacao, v1, v2));
           

            Console.ReadKey();
        }
    }
}
