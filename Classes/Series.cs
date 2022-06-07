using System;

namespace E_M.Series
{
    public class Series : EntidadeBase
    {
        //Atributos
        private Genero Genero { set; get; }
        private string Titulo { set; get; }
        private string Descricao { set; get; }
        private int Ano { set; get; }
        private bool Excluido {get; set; }

        // Métodos
	    public Series(int id, Genero genero, string titulo, string descricao, int ano)
	    {
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

         public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.Id;
		}

		public bool retornaExcluido()
		{
			return this.Excluido;
		}

        public void Excluir()
		{
			this.Excluido = true;
		}

    }
}