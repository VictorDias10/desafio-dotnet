/*
 *Teste 02: Exibir média do Aluno recebendo (x) quantidade de Notas
Problema: Um aluno tem várias provas durante o ano e deseja um sistema que ele
informe o Seu Nome e a nota que recebeu.
Observação: Para cada nota informada deve ser exibido o nome do aluno, a
quantidade de provas, o total de notas, e qual a média desse aluno. 
 */
namespace Teste2.Console.MediaAluno; 
using System;using Teste2.Console.Classes;class Program{    static void Main(string[] args)    {        Aluno aluno = new Aluno();                Console.WriteLine("Bem vindo ao Teste 02, para iniciarmos qual é o seu nome?");        aluno.nomeAluno = Console.ReadLine();        aluno.quantidadeDeProvas = 0;        while (true)
        {
            Console.WriteLine(String.Concat("\n", aluno.nomeAluno, " por favor, nos informe qual foi sua nota na prova?"));
            aluno.notas.Add(float.Parse(Console.ReadLine()));
            aluno.quantidadeDeProvas = aluno.quantidadeDeProvas + 1;

            float totalNotas = 0;
            foreach (float nota in aluno.notas)
            {
                totalNotas = totalNotas + nota;
            }
            float mediaNotas = totalNotas / aluno.quantidadeDeProvas;
            Console.WriteLine($"Nome: {aluno.nomeAluno}");
            Console.WriteLine($"Quantidade de provas: {aluno.quantidadeDeProvas}");
            Console.WriteLine($"Total de nota: {totalNotas}");
            Console.WriteLine($"Sua média é de: {mediaNotas}");        }
    }}