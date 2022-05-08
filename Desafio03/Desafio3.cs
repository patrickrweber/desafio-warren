//Dado um vetor de números e um número n. Determine a soma com o menor número de elementos entre os números
//do vetor mais próxima de n e também mostre os elementos que compõem a soma. Para criar a soma, utilize
//qualquer elemento do vetor uma ou mais vezes.

//Exemplo:
//Entrada de dados:
//N = 10
//V = [2, 3, 4]
//Saída de dados:
//10
//[2, 4, 4]
//[3, 3, 4]

//Explicação:
//Se N = 10 e V = [2, 3, 4] você pode utilizar as seguintes soma: [2, 2, 2, 2, 2], [2, 2, 3, 3], [2, 4, 4]
//ou[3, 3, 4].Como a quantidade de elementos em [2, 4, 4] e[3, 3, 4] é igual, os dois conjuntos devem ser
//mostrados.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio03
{
    class Desafio3
    {
        
        static void Main(string[] args)
        {
            #region Declaracao Var
            List<int> numeros = new List<int>();
            int qtd = 1;
            string opcao = null;
            
            #endregion

            #region Capturar n
            Console.WriteLine("Defina o número n: ");
            int n = int.Parse(Console.ReadLine());
            #endregion

            #region Capturar Vetor
            do
            {
                Console.Clear();
                Console.WriteLine("Defina o  "+qtd+"º número do vetor:");
                numeros.Add(int.Parse(Console.ReadLine()));
                Console.Write("Vetor: ");
                foreach (int numero in numeros)
                {
                    Console.Write("["+numero+"] ");
                }
                qtd++;
                Console.WriteLine();
                Console.WriteLine("Deseja adicionar mais um número no vetor? S/N");
                opcao = Console.ReadLine();
            }while (opcao == "s" || opcao == "S");
            #endregion

            #region Ordenar vetor decrescente
            numeros.Sort();
            numeros.Reverse();
            Console.Write("Vetor Ordenado Decrescente: ");
            foreach (int numero in numeros)
            {
                Console.Write("[" + numero + "] ");
            }
            #endregion

            int nTemporario = n;
            List<int> numerosUsados = new List<int>();
            int qtdNumerosUsados = 0;
            foreach (int numero in numeros)
            {
                while(nTemporario >= numero)
                {
                        nTemporario -= numero;
                    numerosUsados.Add(numero);
                    qtdNumerosUsados++;
                }
            }
            Console.WriteLine();
            Console.Write("Numeros Usados:");
            foreach(int usado in numerosUsados)
            {
                Console.Write("[" + usado + "]");
            }
            
            Console.ReadKey();
        }
    }
}
