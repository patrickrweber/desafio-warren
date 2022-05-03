using System;
using System.Collections.Generic;

namespace WarrenTech
{
    class Program
    {
        public static int Inverter(int n)
        {
            int resultado = 0;
            while (n > 0)
            {
                resultado = 10 * resultado + n % 10;
                if (resultado == 0)
                {
                    goto Fim;
                }
                n /= 10;
            }
        Fim:
            return resultado;
        }

        static void Main(string[] args)
        {
            int cont = 0;
            int qtdDigitos = 0;
            int contador = 0;
            for (int i = 0; i < 1000000; i++)
            {
                int soma = i + Inverter(i);
                int quantidade = soma;
                while (quantidade > 0)
                {
                    qtdDigitos++;
                    quantidade /= 10;
                }
                while (soma > 0)
                {
                    int digito = soma % 10;
                    List<int> listaNumeros = new List<int>();
                    listaNumeros.Add(digito);
                    foreach (int num in listaNumeros)
                    {
                        if (num % 2 == 1 && num != 0)
                        {
                            contador++;
                        }
                    }
                    soma /= 10;
                }
                if (contador == qtdDigitos && contador > 0)
                {
                    cont++;
                }
                contador = 0;
                qtdDigitos = 0;
            }
            Console.WriteLine(cont);
            Console.ReadKey();
        }
    }
}
