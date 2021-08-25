using System;
using System.Collections.Generic;

namespace OrdenacaoAlfaNumerica_Console
{
    public class Pessoa : IComparable
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        
        public override string ToString()
        {
            return $"[Nome: {Nome}, Idade: {Idade} anos]";
        }

        public int CompareTo(object obj)
        {
            Pessoa that = obj as Pessoa;
            return this.Nome.CompareTo(that.Nome);
        }       
    }
}
