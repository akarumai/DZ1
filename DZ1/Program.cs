using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace DZ1
{
    public class Programm
    {
        static void Main()
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double y;
            Console.WriteLine($"Значение равно: {y = (Math.Pow(a, 2) + 10) / (Math.Sqrt(Math.Pow(a, 2) + 1))}");
        }
    }
}
