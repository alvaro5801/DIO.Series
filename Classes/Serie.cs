using System;
using DIO.Serie;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        //Atributos     

        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string Descrição { get; set; }

        private int Ano { get; set; }

        private new bool Excluido   {get; set;}
        

        //Metodos 

        public Serie (int id, Genero genero, string titulo, string descrição, int ano, string descricao)
        
        {
            this.Id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descrição = descrição;
            this.Ano = Ano;
            this.Excluido = false;
         }

        public Serie()
        {
        }

        public Serie(int id, Genero genero, string titulo, int ano, string descricao)
        {
            Id = id;
            Genero = genero;
            Titulo = titulo;
            Ano = ano;
        }

        public override string ToString()
         {
             // Environment.Newline htt://docs.microsoft.com/en-us/dotnet/api/system/.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero" + this.Genero + Environment.NewLine;
            retorno += "Titulo" + this.Titulo + Environment.NewLine;
            retorno += "Descrição" + this.Descrição + Environment.NewLine;
            retorno += "Ano" + this.Ano + Environment.NewLine;
            return retorno;
         }

        internal object retornaExcluido()
        {
              return this.Titulo;        }

        public string retornaTitulo()
          {
            return this.Titulo;
          }  

            internal int retornaId()   
         {
             return this.Id;
         }

         
        public void Exclui ()
         {this.Excluido = true;
         }
    }
}