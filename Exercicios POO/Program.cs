using Exercicios_POO.Classes;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

// Os Exemplos de Funcionalidade para modificadores de acesso está na classe TV 

#region Exercício Caneta
////Exercício Caneta:
Console.WriteLine("Exercício Caneta:  \n");
Caneta c1 = new Caneta();
c1.Marca = "BIC";
c1.Cor = "Azul";
c1.Apresentação(1);
Console.WriteLine();
Caneta c2 = new Caneta();
c2.Marca = "Faber Castel";
c2.Cor = "Vermelha";
c2.Apresentação(2);
Console.WriteLine("\n");
#endregion

#region Exercício Pessoa
//exercício Pessoa
Console.WriteLine("Exercício Pessoa:\n");
Pessoa p1 = new Pessoa();

p1.NomeCompleto = "Kaio Mazzotti";
p1.Email = "kaio.mazzotti@gmail.com";
p1.PrimeiroNome = "Kaio";
p1.Apresentar();
Console.WriteLine("\n");
#endregion

#region Exercício TV
//Exercício TV (exemplo já utilizando construtor!)
//todos os modificadores utilizados na classe TV como exemplo!
Console.WriteLine("\nExercício TV:\n");
Tv tv = new Tv(1,5,false);
tv.AumentaVolume();
Console.WriteLine();
tv.MudaCanal();
Console.WriteLine();
tv.Liga();
Console.WriteLine();
tv.MudaCanal();
Console.WriteLine();
Console.WriteLine(" O volume da sua TV é " + tv.Volume +"\n");
tv.DiminuiVolume();
Console.WriteLine();
tv.AumentaVolume();
Console.WriteLine();
tv.Desliga();
Console.WriteLine();
tv.AumentaVolume();


#endregion