using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            // exemplo de data
            DateTime dtNascimento;
            Console.WriteLine("Informe sua data de aniversario: ");
            dtNascimento = Convert.ToDateTime(Console.ReadLine());

            TimeSpan intervalo = DateTime.Now - dtNascimento;

            int idade = intervalo.Days / 365;

            Console.WriteLine(idade + " Anos");
            Console.ReadKey();

            //exemplo de esplit
            string paises1 = "Brasil,Colombia,Equador,Paraguai";
            string[] seperacao1 = paises1.Split(',');

            if (seperacao1[0] == "Brasil")
            {
                Console.WriteLine("Brazoca");
            }

            Console.ReadKey();

            //exemplo de substring
            string paises2 = "Brasil,Colombia,Equador,Paraguai";
            string[] seperacao2 = paises2.Split(',');

            if (seperacao2[0] == "Brasil")
            {
                Console.WriteLine("Brzoca");
                Console.WriteLine(seperacao2[0].Substring(0, 3));
            }

            Console.ReadKey();


        }
    }
}
