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
        string menuCadastro;
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
            Console.Write("Idade: ");
            idadeAlunoValida = int.TryParse(Console.ReadLine(), out idadeAluno[i]);
            while(idadeAlunoValida == false)
            {
                Console.WriteLine(" Idade inválida, insira novamente. \n Idade:");
                idadeAlunoValida = int.TryParse(Console.ReadLine(), out idadeAluno[i]);
                continue;
            }
            Console.Write("Nota 1: ");
            nota1Valida = double.TryParse(Console.ReadLine(), out nota1[i]);
            while(nota1Valida == false || nota1[i] > 10.0)
            {
                Console.Write(" Nota inválida, insira novamente. \n Nota 1:");
                nota1Valida = double.TryParse(Console.ReadLine(), out nota1[i]);
                continue;
            }
            Console.Write("Nota 2: ");
            nota2Valida = double.TryParse(Console.ReadLine(), out nota2[i]);
            while(nota2Valida == false || nota2[i] > 10.0)
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

                    // código da listagem
                    break;

                case 2:
                    // =====================
                    // BUSCA
                    // =====================

                    // código da busca
                    break;

                case 3:
                    // =====================
                    // APROVAÇÃO
                    // =====================

                    // código dos aprovados
                    break;

                case 4:
                    // =====================
                    // MÉDIA DA TURMA
                    // =====================

                    // código da média da turma
                    break;

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