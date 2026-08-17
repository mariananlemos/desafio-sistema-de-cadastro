using System;

public class Listagem
{
    // Declaração de Variáveis Privadas Teste: Confirmar nomes das Variávies com Aline
    private static string[] nomes = new string[10];
    private static int[] idades = new int[10];
    private static double[] nota1 = new double[10];
    private static double[] nota2 = new double[10];
    private static int totalAlunos = 0;

    // Método de Listagem (função principal):
    public static void ListarAlunos()
    {
        Console.WriteLine("\n===== LISTA DE ALUNOS CADASTRADOS =====\n");

        // Condição para tratar cadastro zerado:
        if (totalAlunos == 0)
        {
            Console.WriteLine("Nenhum aluno cadastrado!");
            Console.WriteLine("---------------------------------------");
            return;
        }

        // Laço para percorrer os arrays de alunos (Ajustar Cadastro)
        for (int i = 0; i < totalAlunos; i++)
        {
            double media = CalcularMedia(nota1[i], nota2[i]);

            // Exibir os dados dos alunos em Lista:
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Idade: {idades[i]}");
            Console.WriteLine($"Média: {media:F2}");  // Verificar se deixamos com 1 ou 2 casa!
        }
        Console.WriteLine("\n---------------------------------------");
        Console.WriteLine($"Total de Alunos Cadastrados: {totalAlunos}");
    }

    // Método para calcular a média das notas:
    private static double CalcularMedia(double nota1, double nota2)
    {
        return (nota1 + nota2) / 2;
    }

    // Método de Teste de validação: Provisório
    public static void AdicionarDadosTeste()
    {
        // Adicionar dados de teste:
        nomes[0] = "João Silva";
        idades[0] = 20;
        nota1[0] = 7.5;
        nota2[0] = 8.0;

        nomes[1] = "Maria Santos";
        idades[1] = 22;
        nota1[1] = 9.0;
        nota2[1] = 8.5;

        nomes[2] = "Pedro Oliveira";
        idades[2] = 18;
        nota1[2] = 6.0;
        nota2[2] = 7.0;

        nomes[3] = "Amauri Torres";
        idades[3] = 19;
        nota1[3] = 6.0;
        nota2[3] = 5.5;

        totalAlunos = 4; // Atualização do total de alunos cadastrados
    }
}