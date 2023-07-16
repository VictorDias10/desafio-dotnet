/*
 Teste 03: Exibir média de cada aluno
Problema: Um Professor tem vários alunos e ele quer calcular a média anual de
cada aluno, se a média anual do aluno for menos que 6,5 ele está reprovado caso
seja ao contrário, ele foi aprovado.
Observações: Deve ser informado o Nome, a nota do primeiro e do segundo
semestre de cada aluno.
Após digitar o nome, a nota do primeiro e do segundo semestre, exibir a média anual
do aluno e se ele foi aprovado ou não. Após exibir se o aluno foi aprovado ou não,
recomeçar o fluxo de perguntar o nome e as notas.
 */

class Program
{
    static void Main(string[] args)
    {
        float notaPrimeiroSemestre = 0, notaSegundoSemestre = 0, notaMedia = 0;
        string nomeAluno;
        string status;

        Console.WriteLine("Bem vindo ao Teste 03");
        while (true)
        {
            Console.WriteLine("\nInforme o nome do aluno");
            nomeAluno = Console.ReadLine();

            Console.WriteLine($"Qual foi a nota do primeiro Semestre do aluno {nomeAluno}?");
            notaPrimeiroSemestre = float.Parse(Console.ReadLine());

            Console.WriteLine($"Qual foi a nota do segundo Semestre do aluno {nomeAluno}?");
            notaSegundoSemestre = float.Parse(Console.ReadLine());

            notaMedia = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
            if (notaMedia >= 6.5)
            {
                status = "Aprovado";
            }
            else
            {
                status = "Reprovado";
            }

            Console.WriteLine($"Nome do aluno: {nomeAluno}");
            Console.WriteLine("Média: " + notaMedia.ToString());
            Console.WriteLine($"O aluno foi: {status}");
        }

    }
}
