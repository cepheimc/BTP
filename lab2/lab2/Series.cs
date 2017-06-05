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

        public Series() { }
        public Series(List<T> objs)
        {
            this.obj = objs;
        }
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
           if(x < 0 || x >= obj.Count)
            {
                throw new IndexOutOfRangeException("номер выходит за рамки списка");
            }
            else 
            {            
                obj.RemoveAt(x);
                Console.WriteLine("Объект успешно удален");            
           }

        }
        public void Display()
        {
            for (int i = 0; i < obj.Count; i++)
                Console.WriteLine("№ " + i + "    " + obj[i]);
        }
    }
}
