namespace Aula2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*Calcule a média aritmética das três notas de um aluno e mostre, além do valor da média, uma mensagem de:
			- "Aprovado", caso a média seja igual ou superior a 7; 
			- “Em prova final” caso a média seja menor que 7 e maior ou igual a 4; e 
			- “Reprovado", caso contrário.
			 */

			double nota1, nota2, nota3, media;
			Console.WriteLine("***** Sistema Acadêmico ******");
			Console.WriteLine("Digite a primeira nota: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a segunda nota: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a terceira nota: ");
			nota3 = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2 + nota3 ) / 3;
			Console.WriteLine("Média = {0}", media.ToString("0.0"));
			if(media >= 7)
			{
				Console.WriteLine("Aprovado!");
			}
			else if(media < 4) {
				Console.WriteLine("Reprovado!");
			}
			else
			{
				Console.WriteLine("Em prova final");
			}
			
			


		}
	}
}