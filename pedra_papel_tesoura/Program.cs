using System;

public class Program
{
	public static void Main()
	{
		Console.ForegroundColor = ConsoleColor.DarkRed;
		Console.WriteLine(new string ('=', 29));
		Console.WriteLine("Jogo de pedra, papel, tesoura");
		Console.WriteLine(new string ('=', 29));
		Console.ResetColor();
		return2:
			Random aleatorio = new Random();
		int numeroaleatorio = aleatorio.Next(0, 3);
		string[] escolha =
		{
			"Pedra",
			"Papel",
			"Tesoura"
		};
		string escolhadocomputador = escolha[numeroaleatorio];
		returnone:
			Console.Write("Escolha 'D' para pedra, 'P' para papel ou 'T' para tesoura: ");
		string escolhadousuario = Console.ReadLine().ToUpper();
		if (escolhadousuario == "D" || escolhadousuario == "P" || escolhadousuario == "T")
		{
			if (escolhadousuario == "D")
			{
				escolhadousuario = escolha[0];
			}
			else if (escolhadousuario == "P")
			{
				escolhadousuario = escolha[1];
			}
			else
			{
				escolhadousuario = escolha[2];
			}

			Console.WriteLine($"voce escolheu: {escolhadousuario} ");
			Console.WriteLine($"o computador escolheu: {escolhadocomputador} ");
			if (escolhadousuario == escolhadocomputador)
			{
				Console.WriteLine("Empate");
			}
			else if ((escolhadousuario == escolha[0] && escolhadocomputador == escolha[1]) || (escolhadousuario == escolha[2]) || (escolhadousuario == escolha[2] && escolhadocomputador == escolha[0]))
			{
				Console.WriteLine("que pena! voce perdeu. ");
			}
			else
			{
				Console.WriteLine("Parabens! voce ganhou! ");
				Console.WriteLine();
			}
		}
		else
		{
			Console.WriteLine("valor invalido. Tente Novamente!");
			goto returnone;
		}

		goto return2;
	}
}