// ====================================================================================
// CÓDIGO LISTAGEM DE ALUNOS (Marcia)
// Para colocar dentro do "case 1:" do menu geral na main.cs conforme solicitado!
// ====================================================================================

// Console.WriteLine("\n===== LISTA DE ALUNOS CADASTRADOS =====\n");

// // 1. CONTA QUANTOS ALUNOS FORAM CADASTRADOS NA MAIN
// int totalAlunos = 0;
// foreach (string nome in nomeAluno)
// {
//     // Verifica se a posição da matriz não está nula ou vazia
//     if (nome != null && nome != "")
//     {
//         totalAlunos++;
//     }
// }

// // 2. CONDIÇÃO PARA TRATAR CADASTRO ZERADO:
// if (totalAlunos == 0)
// {
//     Console.WriteLine("Nenhum aluno cadastrado!");
//     Console.WriteLine("---------------------------------------");
// }
// else
// {
//     // 3. LAÇO PARA PERCORRER A MATRIZ DE 10 POSIÇÕES QUE A ALINE CRIOU
//     for (int i = 0; i < 10; i++)
//     {
//         // Se encontrar uma posição vazia no meio da matriz, pula para o próximo loop
//         if (nomeAluno[i] == null || nomeAluno[i] == "") 
//         {
//             continue; 
//         }

//         // Calcula a média das notas utilizando os nomes oficiais (nota1 e nota2)
//         double media = (nota1[i] + nota2[i]) / 2.0;

//         // Exibe os dados do aluno atual da lista
//         Console.WriteLine("---------------------------------------");
//         Console.WriteLine($"Nome: {nomeAluno[i]}");
//         Console.WriteLine($"Idade: {idadeAluno[i]}");
//         Console.WriteLine($"Média: {media:F2}"); 
//     }
    
//     Console.WriteLine("\n---------------------------------------");
//     Console.WriteLine($"Total de Alunos Cadastrados: {totalAlunos}");
// }
