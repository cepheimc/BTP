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
            Console.WriteLine("Выберите тип функции: 1.Эллипс 2.Гипербола 3.Парабола");
            int ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:
                    {
                        List<Ellipse> ell = new List<Ellipse>();
                        ell.Add(new Ellipse(1, 1, 1));
                        ell.Add(new Ellipse(2, 1, 1));
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
                                        try
                                        {
                                            Console.WriteLine("Введите данные");
                                            Console.Write("x = ");
                                            double x = double.Parse(Console.ReadLine());
                                            Console.Write("a = ");
                                            double a = double.Parse(Console.ReadLine());
                                            Console.Write("b = ");
                                            double b = double.Parse(Console.ReadLine());
                                            obj1.Add(new Ellipse(x, a, b));
                                        }
                                        catch(FormatException)
                                        {
                                            Console.WriteLine("Ошибка: ввели не число");
                                        }
                                        catch (NumbException ex)
                                        {
                                            Console.WriteLine("Ошибка: " + ex.mess);
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        try
                                        {
                                            obj1.RemoveAt();
                                        }
                                        catch(IndexOutOfRangeException ex)
                                        {
                                            Console.WriteLine("Ошибка: " + ex.Message);
                                        }
                                        break;
                                    }
                            }
                            Console.WriteLine("Продолжить - enter Выход = esc");
                            cki = Console.ReadKey();
                        } while (cki.Key != ConsoleKey.Escape);
                        break;
                    }
                case 2:
                    {
                        List<Hiperbola> hip = new List<Hiperbola>();
                        hip.Add(new Hiperbola(1, 1, 1));
                        hip.Add(new Hiperbola(1, 2, 1));
                        hip.Add(new Hiperbola(3, 2, 1));
                        Series<Hiperbola> obj2 = new Series<Hiperbola>(hip);
                        do
                        {
                            Console.WriteLine("Выберите действие: 1.Вывести 2.Добавить 3.Удалить: ");
                            int change = int.Parse(Console.ReadLine());
                            switch (change)
                            {
                                case 1:
                                    {
                                        obj2.Display();
                                        break;
                                    }
                                case 2:
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите данные");
                                            Console.Write("x = ");
                                            double x = double.Parse(Console.ReadLine());
                                            Console.Write("a = ");
                                            double a = double.Parse(Console.ReadLine());
                                            Console.Write("b = ");
                                            double b = double.Parse(Console.ReadLine());
                                            obj2.Add(new Hiperbola(x, a, b));
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Ошибка: ввели не число");
                                        }
                                        catch (NumbException ex)
                                        {
                                            Console.WriteLine("Ошибка: " + ex.mess);
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        try
                                        {
                                            obj2.RemoveAt();
                                        }
                                        catch(IndexOutOfRangeException ex)
                                        {
                                            Console.WriteLine("Ошибка: " + ex.Message);
                                        }
                                        break;
                                    }
                            }
                            Console.WriteLine("Продолжить - enter Выход = esc");
                            cki = Console.ReadKey();
                        } while (cki.Key != ConsoleKey.Escape);
                        break;
                    }
                case 3:
                    {
                        List<Parabola> par = new List<Parabola>();
                        par.Add(new Parabola(1, 1));
                        par.Add(new Parabola(1, 2));
                        par.Add(new Parabola(3, 2));
                        Series<Parabola> obj3 = new Series<Parabola>(par);
                        do
                        {
                            Console.WriteLine("Выберите действие: 1.Вывести 2.Добавить 3.Удалить: ");
                            int change = int.Parse(Console.ReadLine());
                            switch (change)
                            {
                                case 1:
                                    {
                                        obj3.Display();
                                        break;
                                    }
                                case 2:
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите данные");
                                            Console.Write("x = ");
                                            double x = double.Parse(Console.ReadLine());
                                            Console.Write("p = ");
                                            double p = double.Parse(Console.ReadLine());
                                            obj3.Add(new Parabola(x, p));
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Ошибка: ввели не число");
                                        }
                                        catch (NumbException ex)
                                        {
                                            Console.WriteLine("Ошибка: " + ex.mess);
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        try
                                        {
                                            obj3.RemoveAt();
                                        }
                                        catch(IndexOutOfRangeException ex)
                                        {
                                            Console.WriteLine("Ошибка: " + ex.Message);
                                        }
                                        break;
                                    }
                            }
                            Console.WriteLine("Продолжить - enter Выход = esc");
                            cki = Console.ReadKey();
                        } while (cki.Key != ConsoleKey.Escape);
                        break;
                    }
            }
            
        }
    }
}
