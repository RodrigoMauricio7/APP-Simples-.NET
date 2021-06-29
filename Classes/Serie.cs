using System;
namespace ListaArtilheiros
{
    public class Serie : EntidadeBase
    {
        //Atributos
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set;}
        private bool Excluido { get; set; }
        
        //Método construtor
        public Serie(int id, Genero Genero, string Titulo, string Descricao, int Ano)
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
            string retorno = "";
            retorno += "Genero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descricao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
            return retorno;
        }
        public string retornaNome()
        {
            return this.Nome;
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