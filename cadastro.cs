bool nota1Valida = false;
bool nota2Valida = false;
bool idadeAlunoValida = false;
public static string menuCadastro;
public static string[] nomeAluno = new string[10];
public static int[] idadeAluno = new int[10];
public static float[] nota1 = new float[10];
public static float[] nota2 = new float[10];

for(int i = 0; i < 10; i++)
{
    Console.WriteLine("Nome: ");
    nomeAluno[i] = Console.ReadLine();
    Console.WriteLine("Idade: ");
    idadeAlunoValida = int.TryParse(Console.ReadLine(), out idadeAluno[i]);
	while(idadeAlunoValida == false)
	{
    	Console.WriteLine(" Idade inválida, insira novamente. \n Idade:");
		idadeAlunoValida = int.TryParse(Console.ReadLine(), out idadeAluno[i]);
		continue;
	}
    Console.WriteLine("Nota 1: ");
    nota1Valida = float.TryParse(Console.ReadLine(), out nota1[i]);
    while(nota1Valida == false)
	{
		Console.WriteLine(" Nota inválida, insira novamente. \n Nota 1:");
		nota1Valida = float.TryParse(Console.ReadLine(), out nota1[i]);
		continue;
	}
    Console.WriteLine("Nota 2: ");
    nota2Valida = float.TryParse(Console.ReadLine(), out nota2[i]);
	while(nota2Valida == false)
	{
		Console.WriteLine(" Nota inválida, insira novamente. \n Nota 2:");
		nota2Valida = float.TryParse(Console.ReadLine(), out nota2[i]);
        continue;
	}
}

