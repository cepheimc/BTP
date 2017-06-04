using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Series<T>
    {
        public List<T> obj {get; set;}
   //     public List<Hiperbola> hip { get; set; }
    //    public List<Parabola> par { get; set; }
        public Series() { }
        public Series(List<T> objs)
        {
            this.obj = objs;
        }
   /*     public Series(List<Hiperbola> hiperbola)
        {
            this.hip = hiperbola;
        }
        public Series(List<Parabola> parabola)
        {
            this.par = parabola;
        }*/
        public void Add(T m)
        {
            obj.Add(m);
            Console.WriteLine("Объект успешно добавлен");
        }
        public void RemoveAt()
        {
            for (int i = 0; i < obj.Count; i++ )
                Console.WriteLine("№ "+i+"    "+obj[i]);
            Console.Write("Введите номер объекта: ");
            int x = int.Parse(Console.ReadLine());
            obj.RemoveAt(x);
            Console.WriteLine("Объект успешно удален");
        }
        public void Display()
        {
           // Console.Clear();
            for (int i = 0; i < obj.Count; i++)
                Console.WriteLine("№ " + i + "    " + obj[i]);
        }
    }
}
