using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList numbers = new SortedList();

            numbers.Add(1);
            numbers.Add(6);
            numbers.Add(2);
            numbers.Add(-19);
            numbers.Add(20);

            numbers.SetSortStrategy(new QuickSort());
            numbers.Sort();

            numbers.SetSortStrategy(new MergeSort());
            numbers.Sort();

            numbers.SetSortStrategy(new Maxim());
            numbers.SortMax();

            numbers.SetSortStrategy(new Minim());
            numbers.SortMin();

            Console.ReadKey();
        }
    }
      

    abstract class SortStrategy   //интерфейс паттерна Стратегия
    {
        public abstract void Sort(List<int> list);
    }

    class QuickSort : SortStrategy     //конкретный алгоритм
    {
        public override void Sort(List<int> list)
        {
            list.Sort(); 
            Console.WriteLine("QuickSorted list ");
        }
    }

    class MergeSort : SortStrategy     //конкретный алгоритм
    {
        private static List<int> MergeS(List<int> unsorted)
        {
            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int middle = unsorted.Count / 2;
            for (int i = 0; i < middle;i++)  
            {
                left.Add(unsorted[i]);
            }
            for (int i = middle; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = MergeS(left);
            right = MergeS(right);
            return Merge(left, right);
        }

        private static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();

            while(left.Count > 0 || right.Count>0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if(left.Count>0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());    
                }    
            }
            return result;
        }
        public override void Sort(List<int> list)
        {
            list = MergeS(list); 
            Console.WriteLine("MergeSorted list ");
        }
    }

    class Maxim : SortStrategy     //конкретный алгоритм
    {
        protected int max;
        public override void Sort(List<int> list)
        {
            max = list.Max(); 
            Console.WriteLine("Max number: ");
        }
    }

    class Minim : SortStrategy     //конкретный алгоритм
    {
        protected int min;
        public override void Sort(List<int> list)
        {
            min = list.Min(); 
            Console.WriteLine("Min number: ");
        }
    }

    class SortedList     //класс, использующий паттерн для сортировки списка
    {
        private List<int> _list = new List<int>();
        private SortStrategy _sortstrategy;

        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            this._sortstrategy = sortstrategy;
        }

        public void Add(int number)
        {
            _list.Add(number);
        }

        public void Sort()
        {
            _sortstrategy.Sort(_list);
            foreach (int number in _list)
           {
               Console.WriteLine(" " + number);
            }
            Console.WriteLine();
        }

        public void SortMax()
        {
            _sortstrategy.Sort(_list);
            int max = _list.Max();
                Console.WriteLine(" " + max);
            
            Console.WriteLine();
        }

        public void SortMin()
        {
            _sortstrategy.Sort(_list);
            int min = _list.Min();
            Console.WriteLine(" " + min);

            Console.WriteLine();
        }
    }

}