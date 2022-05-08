using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    class Metodos
    {
        public int CondicaoAlunos()
        {
            Console.WriteLine("Quantos alunos deverão estar presentes ao inciar a aula?");
            return int.Parse(Console.ReadLine());
            
        }
        public int QuantidadeAlunos()
        {
            int tempoChegada;
            int contAlunos = 1;
            string opcao;
            List<int> alunos = new List<int>();
            int alunosPresentes = 0;
            do
            {
                Console.WriteLine("Digite o tempo de chegado do " + contAlunos + "º aluno: ");
                tempoChegada = int.Parse(Console.ReadLine());
                alunos.Add(tempoChegada);
                contAlunos++;
                Console.WriteLine("Há mais alunos para chegar? S/N ");
                opcao = Console.ReadLine();
                Console.Clear();
            } while (opcao == "s" || opcao == "S");
            foreach (int aluno in alunos)
            {
                if (aluno <= 0)
                {
                    alunosPresentes++;
                }
            }
            return alunosPresentes;
        }

        public string VerificarAula(int alunosPresentes, int x)
        {
            string situacao;
            if (alunosPresentes >= x)
            {
               situacao = "Aula normal";
            }
            else
            {
                situacao = "Aula Cancelada";
            }
            return situacao;
        }
    }
}
