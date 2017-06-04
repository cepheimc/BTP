using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{      

     class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            List<Ellipse> ell = new List<Ellipse>();
            ell.Add(new Ellipse(1,1,1));
            ell.Add(new Ellipse(1, 2, 1));
            ell.Add(new Ellipse(3, 2, 1));
            Series<Ellipse> obj1 = new Series<Ellipse>(ell);
            do
            {
                Console.WriteLine("Выберите действие: 1.Вывести 2.Добавить 3.Удалить: ");
                int change = int.Parse(Console.ReadLine());
                switch (change)
                {
                    case 1:
                        {
                            obj1.Display();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите данные");
                            Console.Write("x = ");
                            double x = double.Parse(Console.ReadLine());
                            Console.Write("a = ");
                            double a = double.Parse(Console.ReadLine());
                            Console.Write("b = ");
                            double b = double.Parse(Console.ReadLine());
                            obj1.Add(new Ellipse(x, a, b));
                            break;
                        }
                    case 3:
                        {
                            obj1.RemoveAt();
                            break;
                        }
                }
                Console.WriteLine("Продолжить - enter Выход = esc");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Escape);
        }
    }
}
