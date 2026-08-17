// Método para listar alunos aprovados - Daianne
public static void ListarAprovados()
{
    Console.WriteLine("\n===== ALUNOS APROVADOS =====\n");

    int totalAprovados = 0;

    for (int i = 0; i < totalAlunos; i++)
    {
        double media = CalcularMedia(nota1[i], nota2[i]);

        if (media >= 7)
        {
            Console.WriteLine($"{nomes[i]} - Média {media:F1}");
            totalAprovados++;
        }
    }

    Console.WriteLine("\n---------------------------");
    Console.WriteLine($"Total = {totalAprovados} aluno(s)");
}
