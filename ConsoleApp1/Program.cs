using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!"); // MEU PRIMEIRO HELLO WORLD COM C# !!!!!!
            Console.WriteLine("Laura bobona <3");


            string lu = "Lucas"; // declaração de variável tipo string
            string la = "Laura";
            string resultado = lu + " e " + la + " vão namorar"; // concatenação 
            Console.WriteLine(resultado);


            //----TIPOS DE VARIÁVEIS NUMÉRICAS----//
            int z = 10; //declaração de variável tipo inteiro
            decimal y = 1.33m; //utilizado para calculos financeiros (moeda)
            double y2 = 1.33; //utilizado para cálculos científicos e medições
            float f = 1.33f; //engines de jogos como o Unity devido a performance
            Console.WriteLine(z);
            Console.WriteLine(y);
            Console.WriteLine(y2);
            Console.WriteLine(f);
            //-----------------------------------//


            //----OPERAÇÕES MATEMÁTICAS----//
            int a = z * 2; //multiplicação
            Console.WriteLine(a);

            int b = z / 2; //divisao
            Console.WriteLine(b);

            int c = z - 2; //subtração
            Console.WriteLine(c);

            int d = a + b + c; //adição
            Console.WriteLine(d);
            //-----------------------------------//


            //----RECEBDENDO VALOR----//
            Console.WriteLine("Digite uma palavra");
            string h = Console.ReadLine(); // usuário digita uma string que é armazenada na variável h
            Console.WriteLine("Sua palavra foi armazenada com sucesso na variável!");
            Console.WriteLine(h);

            Console.WriteLine("Digite um número");
            int meuNumero = Convert.ToInt32(Console.ReadLine()); //para receber um valor numérico, devemos converter
            Console.WriteLine("Seu número foi armazenado com sucesso na variável!");
            Console.WriteLine(meuNumero);
            //-----------------------------------//

            // --> Esse foi o meu primeiro contato com a linguagem C#, espero aprender muito mais !
            // --> Código criado no dia 17/10/2022
            // --> Vídeo aula -->https://www.youtube.com/watch?v=PjgP78hzWO4
        }
    }
}
