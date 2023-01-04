using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO.Classes
{
    public class Caneta
    {
        public string Marca { get; set; }
        public string Cor { get; set; }

        public void Apresentação(int n)
        {
            Console.WriteLine($"Caneta nº{n} da marca {Marca} e de cor {Cor} ");
        }
    }
   
}
