using System;

class Program
{
    static void Main()
    {
        // =====================
        // CADASTRO
        // =====================

        // código do cadastro dos alunos.


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