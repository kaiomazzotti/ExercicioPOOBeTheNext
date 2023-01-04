using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO.Classes
{
    public class Pessoa
    {
        public string NomeCompleto { get; set; }
        public string Email { get; set; }
        public string PrimeiroNome { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Primeiro Nome: {PrimeiroNome}, Email: {Email}, Nome Completo: {NomeCompleto}");
        }
    }
}
