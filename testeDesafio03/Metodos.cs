using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testeDesafio03
{
    class Metodos
    {
        public int CapturarN()
        {
            Console.WriteLine("Digite o número N: ");
            return int.Parse(Console.ReadLine());
        }
        public List<int> CapturarVetor(List<int> numeros)
        {
            int qtdVetor = 0;
            string opcao;
            do
            {
                Console.Clear();
                Console.WriteLine("Defina o  " + (qtdVetor + 1) + "º número do vetor:");
                numeros.Add(int.Parse(Console.ReadLine()));
                Console.Clear();
                Console.Write("Vetor: ");
                foreach (int numero in numeros)
                {
                    Console.Write("[" + numero + "] ");
                }
                qtdVetor++;
                Console.WriteLine();
                Console.WriteLine("Deseja adicionar mais um número no vetor? S/N");
                opcao = Console.ReadLine();
            } while (opcao == "s" || opcao == "S");
            return numeros;
        }
        public List<int> SomaNumeros(ref int nTemporario, List<int> numeros)
        {
            List<int> numerosUsados = new List<int>();
            int qtdNumerosUsados1 = 0;
            foreach (int numero in numeros)
            {
                while (nTemporario >= numero)
                {
                    nTemporario -= numero;
                    numerosUsados.Add(numero);
                    qtdNumerosUsados1++;
                }

            }
            return numerosUsados;
        }
        public void MostrarUsados(int nTemporario, List<int> numerosUsados)
        {
            Console.Clear();
            if (nTemporario == 0)
            {
                Console.Write("Numeros Usados:");
                foreach (int usado in numerosUsados)
                {
                    Console.Write("[" + usado + "]");
                }
            }
        }
       
    }
}
