// using System;


// class Menu

// {

//     public static void ExibirMenu()

//     {

//         int opcao;


//         do

//         {

//             Console.WriteLine("\n===== MENU =====");

//             Console.WriteLine("1 - Listar alunos");

//             Console.WriteLine("2 - Buscar aluno");

//             Console.WriteLine("3 - Exibir aprovados");

//             Console.WriteLine("4 - Exibir média da turma");

//             Console.WriteLine("0 - Encerrar");

//             Console.Write("Escolha uma opção: ");


//             opcao = Convert.ToInt32(Console.ReadLine());


//             switch (opcao)

//             {

//                 case 1:

//                     Listagem.ListarAlunos();

//                     break;


//                 case 2:

//                     Busca.BuscarAluno();

//                     break;


//                 case 3:

//                     Aprovacao.ExibirAprovados();

//                     break;


//                 case 4:

//                     Cadastro.ExibirMediaTurma();

//                     break;


//                 case 0:

//                     Console.WriteLine("Sistema encerrado.");

//                     break;


//                 default:

//                     Console.WriteLine("Opção inválida!");

//                     break;

//             }


//         } while (opcao != 0);

//     }

// }
 