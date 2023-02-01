using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/*namespace DZ1
{
    public class DZ1
    {
        static void Main()
        {   /* №1 Задание
             * 
            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());


            double sum = (a + b) / 2;

            Console.WriteLine("Среднее арфетическое чисел = " + sum); */

            /* №2 Задание
             * 
            Console.WriteLine("Ввдите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввдите второе число:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ввдите третье число:");
            double c = Convert.ToDouble(Console.ReadLine());

            double sum = a + b + c;
            double um = a * b * c;

            Console.WriteLine("Сложение чисел = "+sum);
            Console.WriteLine("Умножение чисел = " + um); */


            /* №3 Задание
             * 
            double rub = 68.25;

            Console.WriteLine("Введите кол-во $");
            double usd = Convert.ToDouble(Console.ReadLine());
            double sumusdrub = rub * usd;

            Console.WriteLine("Стоимость долларов в рублях : " + sumusdrub);
            */

            /*РЕШЕБНИК*/

            /*ЗАДАНИЕ №1 Вывести на экран число с точностью до сотых.
            double pi = Math.PI;
            double pi1=Math.Round(pi,2);
            Console.WriteLine(pi1);
            */

            /*ЗАДАНИЕ №2 Вывести на экран число e(основание натурального логарифма) с точностьюдо десятых.*/

            /*ЗАДАНИЕ №3 Составить программу вывода на экран числа, вводимого с клавиатуры. Выводимому числу должно предшествовать сообщение "Вы ввели число".

            Console.WriteLine("Введите число: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Вы вывели число: "+ a);
            */

            /*ЗАДАНИЕ №4 Составить программу вывода на экран числа, вводимого с клавиатуры. После выводимого числа должно следовать сообщение " - вот какое число Выввели".
             * 
            Console.WriteLine("Введите число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a + " - вот какое число Вы ввели");   
            */

            /*ЗАДАНИЕ №5 Вывести на одной строке числа 1, 13 и 49 с одним пробелом между ними.
            int a = 1;
            int b = 13;
            int c = 49;
            Console.WriteLine($"{a} {b} {c}");
            */

            /*ЗАДАНИЕ №6 Вывести на одной строке числа 7, 15 и 100 с двумя пробелами между ними.
            int a = 7;
            int b = 15;
            int c = 100;
            Console.WriteLine($"{a}  {b}  {c}");
            */

            /*ЗАДАНИЕ №7Составить программу вывода на экран в одну строку трех любых чисел с двумя пробелами между ними.
             * 
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a}  {b}  {c}");
            */

            /*ЗАДАНИЕ №8 Составить программу вывода на экран в одну строку четырех любых чисел
            с одним пробелом между ними.

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{a} {b} {c} {d}");
            */

            /*ЗАДАНИЕ №9 Вывести на экран числа 50 и 10 одно под другим.
            int a = 50;
            int b = 10;
            Console.WriteLine($"{a}\n{b}") ;
            */

            /*ЗАДАНИЕ №10 Вывести на экран числа 5, 10 и 21 одно под другим.
            int a = 5;
            int b = 10;
            int c = 21;
            Console.WriteLine($"{a}\n{b}\n{c}");
            */

            /*ЗАДАНИЕ №11 Составить программу вывода на экран "столбиком" четырех любых чисел.
            Console.WriteLine("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Третье число: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Столбик чисел");
            Console.WriteLine($"{a}\n{b}\n{c}\n{d}");
            */

            /*ЗАДАНИЕ №12

            Console.WriteLine("Введите t v x и y");

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int v = Convert.ToInt32(Console.ReadLine());
            int t = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a) 5 10\n   7 см");
            Console.WriteLine($"б) 100 {t}\n   1949 {v}");
            Console.WriteLine($"в) {x} 25\n   {x} {y}");
            */

            /*ЗАДАНИЕ №13
            double x = Convert.ToDouble(Console.ReadLine());
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"a){2*x}\nб){Math.Sin(x)}\nв){a*a}\nг){Math.Sqrt(x)}\nи){Math.Sin(A)*Math.Cos(B)+Math.Cos(A)*Math.Cos(B)}\nк){a*Math.Sqrt(2*b)}\nл){3*Math.Sin(2*A)*Math.Cos(3*B)}\nм){-5*Math.Sqrt(x+Math.Sqrt(y))}");
            */

            /*a)[tex]\frac{ a} {\frac{b} { c} }[/ tex]б) [tex]\frac{ ax + b}{ cx + d}[/ tex]
             * 
            /*Задание %14
            Console.WriteLine("a)(-1)/Math.Pow(2,x)\nб)a/(b*c)\nв)(a/b)*c\nе)((-b)+Math.sqrt(Math.Pow(b,2)-4*a*C))/(2*a)\nи)(1)(1)+(1)/(2)+(1)/(2+(3/5))");
            */

            /*Задание %16
            double x1 = 10;
            double x2 = 20;
            Console.WriteLine(Math.Sqrt(Math.Pow(x1,2)+Math.Pow(x2,2)));
           */

            /*Задание 1.18.
            int s;
            double x;
            s = 10;
            s = -10;
            Console.WriteLine(s);
            x = 17.5;
            x = -2 * x;
            Console.WriteLine(x);
            */
            /*Задание 1.22.
           double x = Convert.ToInt32(Console.ReadLine());
           double y;
           Console.WriteLine(y = 7 * Math.Pow(x,2)-3*x+6);*/


            /*Задание 1.23.
            double a = Convert.ToInt32(Console.ReadLine());
            double y = ((Math.Pow(a,2)+10)/(Math.Sqrt(Math.Pow(a,2)+1)));
            Console.WriteLine(y);
            */

            /*Задание 1.24.
            double x = Convert.ToInt32(Console.ReadLine());
            double y;
            Console.WriteLine(y=Math.Sin((3.2+Math.Sqrt(1+x))/Math.Abs(5*x)));
            */

            /*Задание 1.39.
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double q;
            double z;
            Console.WriteLine(z = (x + ((2 + y) / Math.Pow(x, 2)))/(y+(1/Math.Sqrt(Math.Pow(x, 2)+10))));
            Console.WriteLine(q = 2.8*Math.Sin(x)+Math.Abs(y));
            */
            /*Задание 1.59.
            Console.WriteLine("Введите X а затем Y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int c;
            c = y;
            y = x;
            x = c;
            Console.WriteLine($"X={x}");
            Console.WriteLine($"Y={y}");*/

            /*Задание 2.00.Дано расстояние в сантиметрах. Найти число полных метров в нем.

            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((x/100) + " Метра");
            */
            /*
            Console.WriteLine("Введите килограммы");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine((x / 100) + " Центеров");
            */
            /*
            Console.WriteLine("VVedi x:");
            
            double y;
            if (x < 0)
            {
                Console.WriteLine($"y={Math.Sin(Math.Pow(x,2))}\n   {1 - 2 * Math.Sin(Math.Pow(x, 2)*x)}");
            }
            else
            {
                Console.WriteLine("POSHOL NAXER");
            }
           */
            /*
            {

                Console.WriteLine("Введите x");
                int x = Convert.ToInt32(Console.ReadLine());
                if (x>4)
                {
                    Console.WriteLine("I");
                }
                else
                {
                    Console.WriteLine("II");
                }
            }
            */
            /*
            {
                Console.WriteLine("Введите x , y");
                double x = Convert.ToDouble(Console.ReadLine());
                double y=Convert.ToDouble(Console.ReadLine());

                if (x > y)
                {
                    Console.WriteLine($"{y} Menshe");
                    Console.WriteLine($"{x} Больше");
                }
                else if(y > x) 
                {
                    Console.WriteLine($"{y} Bolshe");
                    Console.WriteLine($"{x} Menshe");
                }
                else
                {
                    Console.WriteLine("одинаковые значения не принимаются");
                }

            }*/
            /*
            double fut = Convert.ToDouble(Console.ReadLine());
            int km =Convert.ToInt32(Console.ReadLine());
            double fut1;
            fut *= 0.305;
            if (fut > km)
            {
                Console.WriteLine($"{km} меньше");
            }
            else
            {
                Console.WriteLine($"{fut} меньше");
            }*/
            /*
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d;
            if (a!=0)
            {
                d=(Math.Pow(b,2)-4*a*c);
                Math.Sqrt( d );
                Console.WriteLine($"Дискриминант равен:{d}");
                if(d==0)
                {
                    Console.WriteLine("Ecть 1 корень");
                }
                else
                {
                    Console.WriteLine("Нет корней");
                }

            }
            else
            {
                Console.WriteLine("а не равно 0");
                
            }*/
            /*
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            
            if(a/b==1)
            {
                Console.WriteLine(a%b);

            }
            else
            {
                Console.WriteLine("a на b нацело неделится");
            }*/

//            double a =Convert.ToDouble(Console.ReadLine());
//           double y;
      //      Console.WriteLine($"Значение равно: {y=(Math.Pow(a,2)+10)/(Math.Sqrt(Math.Pow(a,2)+1)) }");
   //     }
  //  }
//}


