using System;

namespace CalculadoraIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva a data do seu nascimento e então te darei o número de quantos dias você tem de vida");
            Console.Write("Sua data de nascimento: ");
            DateTime nascimento=Convert.ToDateTime(Console.ReadLine());
            DateTime agora=DateTime.Now;
            TimeSpan DiasDeVida= agora - nascimento;
            int dias= DiasDeVida.Days;
            Console.Clear();
            Console.WriteLine($"Você tem exatos {dias} dias de vida.");

            
        }
    }
}
