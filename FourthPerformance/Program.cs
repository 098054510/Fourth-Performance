using System;
using System.Globalization;

namespace FourthPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            double Nota1, Nota2, Nota3, NotaFinal;
            string[] vet = Console.ReadLine().Split(' ');

            Nota1 = double.Parse(vet[0], CultureInfo.InvariantCulture);
            Nota2 = double.Parse(vet[1], CultureInfo.InvariantCulture);
            Nota3 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            NotaFinal = Nota1 + Nota2 + Nota3;
            Console.WriteLine(NotaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if(NotaFinal < 60.0)
            {
                Console.WriteLine(NotaFinal.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("AVISO! DEPENDENCIA");
            }
            Console.ReadLine();
        }
    }
}
