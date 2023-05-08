using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeiro_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu nome: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Informe a sua idade: ");
            UInt16 Idade = Convert.ToUInt16(Console.ReadLine());

            Console.WriteLine("Informe o número do seu documento: ");
            string Documento = Console.ReadLine();

            Console.WriteLine("Informe o nome da sua rua: ");
            string NomeDaRua = Console.ReadLine();

            Console.WriteLine("Informe o número da casa: ");
            UInt32 NumeroDaCasa = Convert.ToUInt32(Console.ReadLine());

            Console.WriteLine("Informe o seu gênero. Pressione F para Feminino, M para Masculino, ou O para Outros.");
            string Genero = Console.ReadKey(true).KeyChar.ToString();

            Console.WriteLine("Olá " + Nome);
            Console.WriteLine("Você tem " + Idade + " anos de idade.");
            Console.WriteLine("O número do documento informado é: " + Documento);
            Console.WriteLine("O nome da sua rua é: " + NomeDaRua);
            Console.WriteLine("O número da sua casa é: " + NumeroDaCasa);
            Console.WriteLine("O seu gênero é: " + Genero);

            Console.WriteLine("Pressione qualquer tecla para encerrar.");
            Console.ReadKey(); 
        }
    }
}
