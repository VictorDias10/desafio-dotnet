/*
Teste 01: Exibir média do Aluno
Problema: O Professor de uma escola precisa calcular a média anual dos seus
alunos, para isso ele deseja um sistema que ele informe a nota do primeiro e do
segundo semestre, e que esse sistema exibe qual é a média.
*/

class Program
{
    static void Main(string[] args)
    {
        decimal notaPrimeiroSemestre = 0, notaSegundoSemestre = 0, notaMedia = 0;

        while(true) {
            Console.WriteLine("\nDigite a nota do primeiro semestre:");
            string input = Console.ReadLine();
            if (Decimal.TryParse(input, out notaPrimeiroSemestre)) {
                break;
            }
            Console.WriteLine("Erro! A nota digitada está no formato incorreto!");
        }

        while(true) {
            Console.WriteLine("\nDigite a nota do segundo semestre:");
            string input = Console.ReadLine();
            if (Decimal.TryParse(input, out notaSegundoSemestre)) {
                break;
            }
            Console.WriteLine("Erro! A nota digitada está no formato incorreto!");
        }

        notaMedia = (notaPrimeiroSemestre + notaSegundoSemestre) / 2;
        Console.WriteLine("Sua média é: " + notaMedia.ToString());
    }
}