using System;

class Program
{
    static void Main()
    {
        // =====================
        // CADASTRO
        // =====================

        bool nota1Valida = false;
        bool nota2Valida = false;
        bool idadeAlunoValida = false;
        string[] nomeAluno = new string[10];
        int[] idadeAluno = new int[10];
        double[] nota1 = new double[10];
        double[] nota2 = new double[10];

        int qtdNulos = 0;

        foreach(string nome in nomeAluno)
        {
            if(nome == null)
            {
                qtdNulos ++;
            }
        }

        Console.WriteLine("Quantidade de alunos cadastrados: " + (10 - qtdNulos));

        int qtdNaoNulos = 10 - qtdNulos;
            
        for(int i = qtdNaoNulos; i < 10; i++)
        {
            Console.Write("Nome: ");
            nomeAluno[i] = Console.ReadLine().ToLower();
            while(nomeAluno[i] == null || nomeAluno[i] == "")
            {
                Console.Write(" Nome inválido, insira novamente. \n Nome:");
                nomeAluno[i] = Console.ReadLine().ToLower();
                continue;
            }
            Console.Write("Idade: ");
            idadeAlunoValida = int.TryParse(Console.ReadLine(), out idadeAluno[i]);
            while(idadeAlunoValida == false)
            {
                Console.Write(" Idade inválida, insira novamente. \n Idade:");
                idadeAlunoValida = int.TryParse(Console.ReadLine(), out idadeAluno[i]);
                continue;
            }
            Console.Write("Nota 1: ");
            nota1Valida = double.TryParse(Console.ReadLine(), out nota1[i]);
            while(nota1Valida == false || nota1[i] > 10.0 || nota1[i] < 0)
            {
                Console.Write(" Nota inválida, insira novamente. \n Nota 1:");
                nota1Valida = double.TryParse(Console.ReadLine(), out nota1[i]);
                continue;
            }
            Console.Write("Nota 2: ");
            nota2Valida = double.TryParse(Console.ReadLine(), out nota2[i]);
            while(nota2Valida == false || nota2[i] > 10.0 || nota2[i] < 0)
            {
                Console.Write(" Nota inválida, insira novamente. \n Nota 2:");
                nota2Valida = double.TryParse(Console.ReadLine(), out nota2[i]);
                continue;
            }
            if(Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                break;
            }
        }


        // =====================
        // MENU
        // =====================

        int opcao;

        do
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1 - Listar alunos");
            Console.WriteLine("2 - Buscar aluno");
            Console.WriteLine("3 - Exibir aprovados");
            Console.WriteLine("4 - Exibir média da turma");
            Console.WriteLine("0 - Encerrar");
            Console.Write("Escolha uma opção: ");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    // =====================
                    // LISTAGEM
                    // =====================
                    // Console.WriteLine("\n===== LISTA DE ALUNOS CADASTRADOS =====\n");

                    // 1. CONTA QUANTOS ALUNOS FORAM CADASTRADOS NA MAIN
                    int totalAlunos = 0;
                    foreach (string nome in nomeAluno)
                    {
                        // Verifica se a posição da matriz não está nula ou vazia
                        if (nome != null && nome != "")
                        {
                            totalAlunos++;
                        }
                    }

                    // 2. CONDIÇÃO PARA TRATAR CADASTRO ZERADO:
                    if (totalAlunos == 0)
                    {
                        Console.WriteLine("Nenhum aluno cadastrado!");
                        Console.WriteLine("---------------------------------------");
                    }
                    else
                    {
                        // 3. LAÇO PARA PERCORRER A MATRIZ DE 10 POSIÇÕES QUE A ALINE CRIOU
                        for (int i = 0; i < 10; i++)
                        {
                            // Se encontrar uma posição vazia no meio da matriz, pula para o próximo loop
                            if (nomeAluno[i] == null || nomeAluno[i] == "") 
                            {
                                continue; 
                            }

                            // Calcula a média das notas utilizando os nomes oficiais (nota1 e nota2)
                            double media = (nota1[i] + nota2[i]) / 2.0;

                            // Exibe os dados do aluno atual da lista
                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine($"Nome: {nomeAluno[i]}");
                            Console.WriteLine($"Idade: {idadeAluno[i]}");
                            Console.WriteLine($"Média: {media:F2}"); 
                        }
                        
                        Console.WriteLine("\n---------------------------------------");
                        Console.WriteLine($"Total de Alunos Cadastrados: {totalAlunos}");
                    }

                    // código da listagem
                    break;

                case 2:
                    Console.WriteLine("Digite o nome do aluno:");
                    string nomeBuscado = Console.ReadLine().ToLower();
                    bool encontrado = false;

                    for (int i =0; i < nomeAluno.Length; i++)
                    {
                        if (nomeBuscado == nomeAluno[i])
                        {
                            Console.WriteLine($"Nome:{nomeAluno[i]}");
                            Console.WriteLine($"Idade:{idadeAluno[i]}");
                            Console.WriteLine($"Nota 1:{nota1[i]}");
                            Console.WriteLine($"Nota 2:{nota2[i]}");
                            Console.WriteLine($"Média:{(nota1[i] + nota2[i])/2}");
                            encontrado = true;
                            break;
                        }
                    }
                    if (encontrado == false)
                    {
                        Console.WriteLine("Aluno não encontrado!");
                    }
                    break;
                case 3:
                    // =====================
                    // APROVAÇÃO
                    // =====================
                    // Aprovacao.ListarAprovados(nomeAluno, nota1, nota2);
                    {
                    Console.WriteLine("\n===== ALUNOS APROVADOS =====\n");

                            int totalAprovados = 0;
                            double somamedias = 0;

                            for (int i = 0; i < nomeAluno.Length; i++)
                            {
                                double media = (nota1[i] + nota2[i]) / 2;
                                somamedias += media; 

                                if (media >= 7)
                                {
                                    Console.WriteLine($"{nomeAluno[i]} - Média {media:F1}");
                                    totalAprovados++;
                                }
                            }
                        double mediaturma = somamedias / nomeAluno.Length;

                            Console.WriteLine("---------------------------------------");
                            Console.WriteLine($"Total = {totalAprovados} aluno(s)");
                            Console.WriteLine($"Média da turma = {mediaturma:F2}");
                                       
                    // código dos aprovados
                    break;
                    }
                case 4:
                    // =====================
                    // MÉDIA DA TURMA
                    // =====================
                    {
                        
                     double somamedias = 0;

                        for (int i = 0; i < nomeAluno.Length; i++)
                                {
                                    somamedias += (nota1[i] + nota2[i]) / 2;
                                }

                        double mediaturma = somamedias / nomeAluno.Length;
                        Console.WriteLine($"Média da turma = {mediaturma:F2}");
                            // código da média da turma
                    break;
                    }
                case 0:
                    Console.WriteLine("Sistema encerrado.");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }
}