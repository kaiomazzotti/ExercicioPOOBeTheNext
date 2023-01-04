using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_POO.Classes
{
    public class Tv 
    {
        public int Canal { get; protected set; } //só posso trocar o Canal por meio do método TrocarCanal aqui dentro
        public int Volume { get; protected set; } // só posso trocar o volume por meio do método Aumenta/Diminui volume aqui dentro
        private bool Ligada { get; set; } // só serve para as funcionalidades aqui dentro da classe, não permitido acesso fora dessa classe 

        public Tv(int canal, int volume, bool ligada)
        {
            Canal = canal;
            Volume = volume;
            Ligada = ligada;
        }

        public void Liga() // qualquer um pode puxar esse método porque o acesso é publico
        {
            Console.WriteLine("Você Ligou a TV!");
            Ligada = true;
        }
        public void Desliga()
        {
            Console.WriteLine("Você Desligou a TV!");
            Ligada = false;
        }

        public int MudaCanal()
        {   if (Ligada)
            {
                bool verificador ;
                          
                    Console.WriteLine("Para qual canal você deseja mudar?");
                    Console.Write(" 1 - Filmes\n 2 - Esportes \n 3 - Notícias  \n\n Canal:  ");
                    
                    verificador = int.TryParse(Console.ReadLine(), out int canal);
                    if (verificador && canal <= 3 && canal >0)
                        Canal = canal;
                    else
                    {
                        Console.WriteLine("\n Você não digitou um número de canal válido\n");
                    return 0;
                    }
                    switch(canal)
                    {
                    case 1:
                            Console.WriteLine("\nMudou para o Canal de Filmes\n");
                            return 1;
                    case 2:
                            Console.WriteLine("\nMudou para o Canal de Esportes\n");
                            return 2;
                    case 3:
                            Console.WriteLine("\nMudou para o Canal de Nóticias\n");
                            return 3;
                    default:
                            return 0;
                    } 
            }
            else
            {
                Console.WriteLine("Você precisa ligar a TV\n");
                return 0;
            }
        }
        public void AumentaVolume()
        {
            if (Ligada)
            {
                Console.WriteLine("Você aumentou o volume!\n");
                Volume++;
                Console.WriteLine($"Volume: {Volume}");
            }
            else
                Console.WriteLine("Você precisa ligar a TV\n");
        }
        public void DiminuiVolume()
        {   if (Ligada)
            {
                Console.WriteLine("Você diminuiu o volume!\n");
                Volume--;
                Console.WriteLine($"Volume: {Volume}");
            }
            else
                Console.WriteLine("Você precisa ligar a TV\n");
        }
    }
}
