#region Proposta Desafio
//Alguns números inteiros positivos n possuem uma propriedade na qual a soma de n + reverso(n) resultam em
//números ímpares. Por exemplo, 36 + 63 = 99 e 409 + 904 = 1313. Considere que n ou reverso(n) não podem
//começar com 0. Existem 120 números reversíveis abaixo de 1000.
//Construa um algoritmo que mostre na tela todos os números n onde a soma de n + reverso(n) resultem em
//números ímpares que estão abaixo de 1 milhão.
#endregion
using System;
namespace WarrenTech
{
    class Desafio1
    {
        static void Main(string[] args)
        {
            #region Declaracao variaveis
            Metodos metodo = new Metodos();
            int reversiveis = 0;
            #endregion

            #region Loop 1 ao 1 milhão
            for (int numero = 0; numero < 1000000; numero++)
            {
                int soma = numero + metodo.InverterNumero(numero);
                int qtdDigitos = metodo.ContarDigitos(soma);
                int impares = metodo.VerificarReversibilidade(soma);
                if (impares == qtdDigitos && impares > 0)
                {
                    reversiveis++;
                }
            }
            #endregion

            #region Saída
            Console.WriteLine(reversiveis);
            Console.ReadKey();
            #endregion
        }
    }
}
