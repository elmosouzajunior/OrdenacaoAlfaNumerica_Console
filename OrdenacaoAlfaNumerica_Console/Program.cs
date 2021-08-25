using System;
using System.Collections.Generic;
using System.Globalization;

namespace OrdenacaoAlfaNumerica_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa("Gustavo Henrique", 36);
            Pessoa pessoa2 = new Pessoa("Elmo Júnior", 39);
            Pessoa pessoa3 = new Pessoa("Patyanne Carvalho", 35);
            Pessoa pessoa4 = new Pessoa("Lucas Pedrosa", 36);

            List<Pessoa> listaPessoas = new List<Pessoa>()
            {
                pessoa1,
                pessoa2,
                pessoa3,
                pessoa4
            };

            List<Pessoa> listaPessoasOrdenada = new List<Pessoa>(listaPessoas);
            
            foreach (var pessoa in listaPessoas)
                Console.WriteLine(pessoa);

            listaPessoasOrdenada.Sort();    
                        
            Console.WriteLine("");
            
            foreach (var pessoa in listaPessoasOrdenada)
                Console.WriteLine(pessoa);

            Console.WriteLine("");

            listaPessoasOrdenada.Sort((obj1, obj2) => obj1.Idade.CompareTo(obj2.Idade));

            foreach (var pessoa in listaPessoasOrdenada)
                Console.WriteLine(pessoa);

            Console.WriteLine("");

            int totalIdade = 0;
            foreach (Pessoa pessoa in listaPessoas)
            {
                totalIdade += pessoa.Idade;
            }

            Console.WriteLine("A idade total das pessoas da lista é: " + totalIdade + " anos");

            double idadeMedia = Convert.ToDouble(totalIdade) / listaPessoas.Count;
            Console.WriteLine("A idade media das " + listaPessoas.Count + " pessoas é: " + idadeMedia.ToString("F2", CultureInfo.InvariantCulture) + " anos");

            Console.ReadLine();
        }
    }
}
