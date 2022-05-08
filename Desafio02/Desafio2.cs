#region Proposta Desafio
//Um professor de programação, frustrado com a falta de disciplina de seus alunos, decidi cancelar a aula se
//menos de x alunos estiverem presentes quando a aula for iniciada. O tempo de chegada varia entre:

//Normal: tempoChegada <= 0
//Atraso: tempoChegada > 0
//Construa um algoritmo que dado o tempo de chegada de cada aluno e o limite x de alunos presentes, determina
//se a classe vai ser cancelada ou não ("Aula cancelada” ou “Aula normal”).

//Exemplo:
//Entrada de dados:
//x = 3
//tempoChegada = [-2, -1, 0, 1, 2]
//Saída de dados:
//Aula normal.

//Explicação:
//Os três primeiros alunos chegaram no horário.Os dois últimos estavam atrasados.O limite é de três alunos,
//portanto a aula não será cancelada.
#endregion
using System;
using System.Collections.Generic;


namespace Desafio02
{
    class Desafio2
    {
        static void Main(string[] args)
        {
            Metodos metodo = new Metodos();

            int condicaoAlunos = metodo.CondicaoAlunos();
            Console.Clear();
            int alunosPresentes = metodo.QuantidadeAlunos();

            string situacaoAula = metodo.VerificarAula(alunosPresentes, condicaoAlunos);
            Console.WriteLine(situacaoAula);
            Console.ReadKey();
        }
    }
}
