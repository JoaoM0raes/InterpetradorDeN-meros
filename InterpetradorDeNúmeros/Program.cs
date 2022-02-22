using System;
using System.IO;
namespace InterpetradorDeNúmeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string números="     __  __      __  __  __  __  __  __ " + Environment.NewLine +
                           "  |  __| __||__||__ |__    ||__||__||  |" + Environment.NewLine +
                           "  | |__  __|   | __||__|   ||__| __||__|";


            StringReader strings = new StringReader(números);

            string primeiraLinha = strings.ReadLine();
            string segundaLinha = strings.ReadLine();
            string terceiraLinha = strings.ReadLine();

            char[] linhaUm = primeiraLinha.ToCharArray();
            char[] linhaDois = segundaLinha.ToCharArray();
            char[] linhaTres = terceiraLinha.ToCharArray();

            string um = "";
            string dois = "";
            string tres = "";

            int cont = 0;

            for (int i = 0; i < primeiraLinha.Length; i++)
            {
                um += linhaUm[i];
                dois += linhaDois[i];
                tres += linhaTres[i];
                if(dois== "  | " && tres== "  | ")
                {
                    Console.Write("1");
                }
                else if (dois== " __|" && tres== "|__ " && um ==" __ ")
                {
                    Console.Write("2");

                }else if (um==" __ " && dois == " __|" && tres== " __|")
                {
                    Console.Write("3");
                }else if (um=="    " && dois== "|__|")
                {
                    Console.Write("4");
                }else if (dois== "|__ " && tres== " __|")
                {
                    Console.Write("5");
                }else if(dois== "|__ " && tres== "|__|")
                {
                    Console.Write("6");
                }else if (um== " __ " && dois == "   |" && tres== "   |")
                {
                    Console.Write("7");
                }else if (dois== "|__|" && tres== "|__|")
                {
                    Console.Write("8");
                }else if (dois== "|__|" && tres== " __|")
                {
                    Console.Write("9");
                }else if (dois== "|  |" && tres== "|__|")
                {
                    Console.Write("0");
                }
                    cont++;
                if (cont == 4)
                {
                    um = "";
                    dois = "";
                    tres = "";
                    cont = 0;
                }

            }
           
        }
    }
}
