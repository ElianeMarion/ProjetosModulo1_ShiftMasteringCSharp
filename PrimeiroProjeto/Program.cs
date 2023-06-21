namespace PrimeiroProjeto
{
	internal class Program
	{
		static void Main(string[] args)
		{

			/*O estatuto da ONG determina que todas as doações recebidas devem gerar um valor para investimento, 
			 * para cobrir momentos de necessidade. O valor do investimento deve ser de 5% da doação. 
			 * Porém, em casos em que as doações ultrapassem R$1000,00 o investimento deve ser de 10% da doação. 
			Sua missão é criar um programa capaz de fazer os cálculos necessários e indicar quanto deve ser investido.
			*/
/*
			double valorDaDoacao, investimento;
			Console.WriteLine("Por favor informe o valor da sua doação: R$");
			valorDaDoacao = Convert.ToDouble(Console.ReadLine());
			if(valorDaDoacao >= 1000)
			{
				//Calculo de 10%
				investimento = valorDaDoacao * 0.1;		
			}
			else
			{
				//Calculo de 5%
				investimento = valorDaDoacao * 0.05;				
			}
			Console.WriteLine("O investimento será de " + investimento);
			Console.WriteLine("Obrigada(o) por sua doação");


			double valorDoacaoMensal;
			Console.WriteLine("Digite o valor mensal de doações: R$ ");
			valorDoacaoMensal = Convert.ToDouble(Console.ReadLine());
			if (valorDoacaoMensal >= 10000)
				Console.WriteLine("Parabéns! O valor das doações é significativo para a ONG");
			else
				Console.WriteLine("O valor das doações precisa ser aumentado para garantir a continuidade dos projetos");
			/*
			int idade;
			Console.WriteLine("Digite sua idade");
			idade = Convert.ToInt32(Console.ReadLine());
			if(idade >= 12) {  //8 >= 12  => F
				Console.WriteLine("Você pode jogar");
			}
			else  //Trata a parte a falsa da condição
			{
				Console.WriteLine("Você não pode jogar");
			}
			/*
			double valorDolar, cotacaoDolar, valorReal;

			Console.WriteLine("Conversão de moeda\n");
			Console.WriteLine("Digite o valor da doação em dólar $ ");
			valorDolar = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a cotação do dolar: R$ ");
			cotacaoDolar = double.Parse(Console.ReadLine());
			valorReal = valorDolar * cotacaoDolar;
			Console.WriteLine("Valor doado em reais foi R$ {0}", valorReal.ToString("0.00"));

			*/

			//Calculadora básica - Efetuar a leitua de 2 números, somar e exibir o resultado
			double numero1, numero2;
			Console.WriteLine("Calculadora básica\n");
			Console.WriteLine("Digite um numero: ");
			numero1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite o segundo numero: ");
			numero2 = double.Parse(Console.ReadLine());

			Console.WriteLine("Selecione a operação desejada\n1-Adição\n2-Subtracao\n3-Divisao\n4-Multiplicação" +
				"\nDigite o numero correpondente a operação");
			int opcao = Convert.ToInt32(Console.ReadLine());
			if(opcao == 1) 
			{
				double soma = numero1 + numero2;
				Console.WriteLine("Soma = " + soma);
			}
			else if(opcao == 2)
			{
				double subtracao = numero1 - numero2;
				Console.WriteLine("Subtração = " + subtracao);
			}
			else if(opcao == 3)
			{
				if (numero2 > 0)
				{
					double divisao = numero1 / numero2;
					Console.WriteLine("Divisão = {0} ", divisao.ToString());
				}
				else
				{
					Console.WriteLine("Não é possível divir por 0");
				}
			}
			else
			{
				double multiplicacao = numero1 * numero2;
				Console.WriteLine("Multiplicação = " + multiplicacao);
			}
			
			
			

		
			//Console.WriteLine("Soma = {0} ", (numero1 + numero2));





			//Entrada - Processamento - Saída

			//Saída => Computador => usuario
			//Console.Write("Texto");
			//Console.WriteLine("Hello, World!");
			//Console.Write("Primeiro Programa");

			//Variáveis => É um espaço na memória RAM para armazenar uma informação
			//int numero, numero2;
			//double salarioBruto;
			//Console.Write("Digite um numero");
			//Entrada de dados  usuario => programa
			/*numero = Convert.ToInt16( Console.ReadLine());
			Console.WriteLine("Valor digitado " + numero + "! ");
			Console.WriteLine("Valor digitado {0} ", numero.ToString());
			Console.WriteLine($"Valor digitado {numero}. ");

			//Atribuição x = 10; variável = valor; processamento =>  variavel = x + 5;
			numero2 = 15;
			numero2 = numero + 10;

			numero2++; //numero2 = numero2 + 1
			numero = 1 + 5;
			numero++;
			numero--; //numero = numero -1
			numero = (5 + 3) / 2;
			//salarioBruto = Convert.ToDouble( Console.ReadLine());
			//salarioBruto = double.Parse( Console.ReadLine());
			
			numero = 5 % 2;
			Console.WriteLine("Resto da divisao" + numero);
			numero2 = 5 / 2;
			Console.WriteLine("Divisao" + numero2);
			salarioBruto = 5.0 / 2;
			Console.WriteLine("Divisao" + salarioBruto);
			*/

		}
	}
}