
//     // Método para listar alunos aprovados - Daianne
// using System;

// public class Aprovacao
// {
//     public static void ListarAprovados(
//         string[] nomeAluno,
//         double[] nota1,
//         double[] nota2)
//     {
//         Console.WriteLine("\n===== ALUNOS APROVADOS =====\n");

//         int totalAprovados = 0;
//         double somamedias = 0;

//         for (int i = 0; i < nomeAluno.Length; i++)
//         {
//             double media = (nota1[i] + nota2[i]) / 2;
//             somamedias += media; 

//             if (media >= 7)
//             {
//                 Console.WriteLine($"{nomeAluno[i]} - Média {media:F1}");
//                 totalAprovados++;
//             }
//         }
//     double mediaturma = somamedias / nomeAluno.Length;

//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine($"Total = {totalAprovados} aluno(s)");
//         Console.WriteLine($"Média da turma = {mediaturma:F2}");
//     }
// }