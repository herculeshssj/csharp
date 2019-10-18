using System;
namespace K19_CopaDoMundo
{
	public class Jogador
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string Posicao { get; set; }
		public DateTime Nascimento{ get; set; }
		public double Altura { get; set; }
		public int SelecaoId { get; set; }
		public Selecao Selecao { get; set; }

		public Jogador()
		{
		}
	}
}

