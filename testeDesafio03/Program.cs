using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeDesafio03
{
    class Program
    {

        static void Main(string[] args)
        {
            #region Declaracao Var
            List<int> numeros = new List<int>();
            int qtd = 0;
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
                Console.WriteLine("Defina o  " + (qtd+1) + "º número do vetor:");
                numeros.Add(int.Parse(Console.ReadLine()));
                Console.Write("Vetor: ");
                foreach (int numero in numeros)
                {
                    Console.Write("[" + numero + "] ");
                }
                qtd++;
                Console.WriteLine();
                Console.WriteLine("Deseja adicionar mais um número no vetor? S/N");
                opcao = Console.ReadLine();
            } while (opcao == "s" || opcao == "S");
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
            List<int> numerosUsados1 = new List<int>();
            List<int> numerosUsados2 = new List<int>();
            List<int> numerosUsados3 = new List<int>();
            List<int> numerosUsados4 = new List<int>();
            int qtdNumerosUsados1 = 0;
            int qtdNumerosUsados2 = 0;
            int qtdNumerosUsados3 = 0;
            int qtdNumerosUsados4 = 0;
            foreach (int numero in numeros)
            {
                while (nTemporario >= numero)
                {
                    nTemporario -= numero;          //Usando numeros ordenados decrescente
                    numerosUsados1.Add(numero);
                    qtdNumerosUsados1++;
                }
            }
            numerosUsados1.Reverse();
            if (nTemporario == 0)
            {
                Console.WriteLine();
                Console.Write("Numeros Usados 1:");
                foreach (int usado in numerosUsados1)
                {
                    Console.Write("[" + usado + "]");
                }
            }
            nTemporario = n;
            numeros.Reverse();
            foreach(int numero in numeros)
            {
                while(nTemporario >= numero)
                {                               //Usando numeros ordenados crescentes
                    nTemporario -= numero;
                    numerosUsados2.Add(numero);
                    qtdNumerosUsados2++;
                }
            }
            if (nTemporario == 0)
            {
                Console.WriteLine();
                Console.Write("Numeros Usados 2:");
                foreach (int usado in numerosUsados2)
                {
                    Console.Write("[" + usado + "]");
                }
            }
            nTemporario = n;
            foreach (int numero in numeros)
            {
                if (nTemporario >= numero)
                {
                    nTemporario -= numero;      //usando todos numeros
                    numerosUsados3.Add(numero);
                    qtdNumerosUsados3++;
                }
            }
            if (nTemporario == 0)
            {
                Console.WriteLine();
                Console.Write("Numeros Usados 3:");
                foreach (int usado in numerosUsados3)
                {
                    Console.Write("[" + usado + "]");
                }
            }
            nTemporario = n;
            while (nTemporario > 0)
            {
                foreach (int numero in numeros)
                {
                        nTemporario -= numero;
                        numerosUsados4.Add(numero);
                        qtdNumerosUsados4++;
                }
            }
            if (nTemporario == 0)
            {
                Console.WriteLine();
                Console.Write("Numeros Usados 4:");
                foreach (int usado in numerosUsados4)
                {
                    Console.Write("[" + usado + "]");
                }
            }
            nTemporario = n;

            
            
            
            Console.ReadKey();
        }
    }
}
