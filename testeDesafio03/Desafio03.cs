using System;
using System.Collections.Generic;

namespace testeDesafio03
{
    class Desafio03
    {

        static void Main(string[] args)
        {
            Metodos metodo = new Metodos();
            int n = metodo.CapturarN();
            List<int> numeros = new List<int>();
            numeros = metodo.CapturarVetor(numeros);
            numeros.Sort();
            numeros.Reverse();
            int nTemporario = n;
            List<int> numerosUsados;
            numerosUsados = metodo.SomaNumeros(ref nTemporario, numeros);
            numerosUsados.Sort();
            metodo.MostrarUsados(nTemporario, numerosUsados);
            Console.ReadKey();
        }
    }
}
