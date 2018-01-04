using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Разработать структуру данных для хранения информации о троллейбусных маршрутах города.  
 * Для каждого маршрута хранится информация: наименование начальной и конечной остановки, 
 * количество троллейбусов на маршруте, время проезда от начала маршрута до конца, 
 * список номеров троллейбусов на маршруте. */

namespace lab3_linq
{
    class Program
    {

        public class Marsh
        {
            public int id;
            public int count;

            public Marsh(int i, int c)

            {
                this.id = i;
                this.count = c;
            }

            public override string ToString()
            {
                return "id = " + this.id.ToString() + " count of troll " + this.count.ToString();
            }
        }

        public class Station
        {
            public int id;
            string name;

            public Station(int i, string n)
            {
                this.id = i;
                this.name = n;
            }
            public override string ToString()
            {
                return this.name.ToString();
            }
        }

        public class Troll
        {
            public int number;
            public int id_m;

            public Troll(int i, int n)
            {
                this.number = n;
                this.id_m = i;
            }

            public override string ToString()
        {
            return " number of troll " + this.number.ToString();
        }
        }

        public class Link
        {
            public int idm;
            public int id1;
            public int id2;
            public int time;

            public Link(int i3,int i1, int i2, int t)
            {
                this.idm = i3;
                this.id1 = i1;
                this.id2 = i2;
                this.time = t;
            }

            public override string ToString()
            {
                return  this.time.ToString();
            }
        }

        static List<Station> s = new List<Station>()
        {
            new Station(1,"station1"),
            new Station(2,"station2"),
            new Station(3,"station3"),
            new Station(4,"station4"),
            new Station(5,"station5"),
            new Station(6,"station6")
        };

        static List<Troll> t = new List<Troll>()
        {
            new Troll(1,1),
            new Troll(1,2),
            new Troll(1,3),
            new Troll(1,4),
            new Troll(2,1),
            new Troll(2,2),
            new Troll(3,1),
            new Troll(3,2),
            new Troll(3,3),
            new Troll(3,4)
        };

        static List<Marsh> m = new List<Marsh>()
        {
            new Marsh(1,4),
            new Marsh(2,2),
            new Marsh(3,4),
        };

        static List<Link> l = new List<Link>()
        {
            new Link(1,1,2,10),
            new Link(1,2,1,7),
            new Link(2,3,4,3),
            new Link(2,4,3,9),
            new Link(3,5,6,6),
            new Link(3,6,5,5),
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Имитация связи один-ко-многим");
            var lnk1 = (from x in m
                       from y in t
                       where x.id == y.id_m
                        select new {v1 = x.id, v2 = y.number}).Distinct();
            foreach (var x in lnk1)
                Console.WriteLine("Номер маршрута " + x.v1 + " номер тролейбуса " + x.v2);
            Console.WriteLine("Имитация связи много-ко-многим");
            var lnk2 = from x in s
                       join l1 in l
                       on x.id equals l1.id1 into temp
                       from t1 in temp
                       join y in s
                       on t1.id2 equals y.id into temp2
                       from t2 in temp2
                       select  new { id1 = x.id, id2 = t2.id };
            foreach (var x in lnk2)
                Console.WriteLine(x);
            Console.WriteLine("Вывести номер маршрута и номер тролейбуса, который к нему относится");
            var q1 = (from x in m
                         from y in t
                         where x.id == y.id_m
                         select new { v1 = x.id, v2 = y.number }).Distinct();
            foreach (var x in q1)
                Console.WriteLine("Номер маршрута " + x.v1 + " номер тролейбуса " + x.v2);
            Console.WriteLine("Вывести все маршруты, их станции и время прохождения");
            var q2 = (from x in m
                      from y in l
                      from z1 in s
                      from z2 in s
                      where x.id == y.idm && (z1.id == y.id1) && (z2.id == y.id2)
                      select new { v1 = x.id, v2 = y.time, v3 = z1.ToString(), v4 = z2.ToString() }).Distinct();
            foreach (var x in q2)
                Console.WriteLine("Номер маршрута " + x.v1 + " время " + x.v2 + " начальная станция " + x.v3 + " конечная станция " + x.v4);
            Console.WriteLine("Сортировка маршрута по времени");
            var q3 = (from x in m
                      from y in l
                      where x.id == y.idm
                      orderby y.time
                      select new { v1 = x.id, v2 = y.time}).Distinct();
            foreach (var x in q3)
                Console.WriteLine("Номер маршрута " + x.v1 + " время " + x.v2);
            Console.WriteLine("Вывести маршруты, которые по времени больше 5 минут");
            var q4 = (from x in m
                      from y in l
                      from z1 in s
                      from z2 in s
                      where x.id == y.idm && (z1.id == y.id1) && (z2.id == y.id2) && (y.time > 5)
                      select new { v1 = x.id, v2 = y.time, v3 = z1.ToString(), v4 = z2.ToString() }).Distinct();
            foreach (var x in q4)
                Console.WriteLine("Номер маршрута " + x.v1 + " время " + x.v2 + " начальная станция " + x.v3 + " конечная станция " + x.v4);
            Console.WriteLine("Вывести маршрут самый долгий по времени");
            var q5 = (from x in m
                      from y in l
                      from z1 in s
                      from z2 in s
                      where x.id == y.idm && (z1.id == y.id1) && (z2.id == y.id2)   
                      orderby y.time descending
                      select new { v1 = x.id, v2 = y.time, v3 = z1.ToString(), v4 = z2.ToString() }).First();
                Console.WriteLine("Номер маршрута " + q5.v1 + " время " + q5.v2 + " начальная станция " + q5.v3 + " конечная станция " + q5.v4);
            Console.WriteLine("Вывести все маршруты, которые в любую сторону длятся больше 5 минут, сгруппировать данные по номеру");
            var q6 = from l1 in l
                      group l1 by l1.idm into g
                      where g.All(l1=>l1.time>5)
                      select new { v2 = g };
            foreach (var x in q6)
                foreach(var y in x.v2)
                Console.WriteLine("Номер маршрута " + y.idm + " время " + y);
            Console.WriteLine("Вывести все маршруты, их станции и время прохождения (Concat)");
            var q7 = (from x in m
                      select new { n=x.id, n1=x.count}).Concat(from y in t
                       select new { n=y.id_m, n1 = y.number});
            foreach (var x in q7)
                Console.WriteLine("Номер маршрута " + x.n + " количество/номер тролейбуса " + x.n1 + " ");
            Console.ReadKey();
        }
    }
}
