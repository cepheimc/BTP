using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        struct edge
        {
            public int u, v;
            public double weight;
            public edge(int u1, int v1, double w)
            {
                u = u1;
                v = v1;
                weight = w;
            }
        };

        static int max = 1000;
        static int[,] tree = new int[max, 3];
        static int[] sets = new int[max];
        static List<edge> graph = new List<edge>();


        static void swap(int k)
        {
            edge temp;
            for(int i = 1; i < k; i++)
            {
                for(int j = 0; j <= k-1; j++)
                {
                    if(graph[j].weight > graph[j+1].weight)
                    {
                        temp = graph[j];
                        graph[j] = graph[j + 1];
                        graph[j + 1] = temp;
                    }
                }
            }

        }

        static int find(int vertex)
        {
            return (sets[vertex]);
        }

        static void join(int u, int v)
        {
            if (u < v) sets[v] = u;
            else sets[u] = v;
        }

        static double build(int N)
        {
            int i, t = 1;
            double len = 0, count = 0;
            swap(N);
            for(i = 1; i <= N; i++)
            {
                for(i = 0; i < N; i++)
                {
                    if(find(graph[i].u) != find(graph[i].v))
                    {
                        tree[t, 1] = graph[i].u;
                        tree[t, 2] = graph[i].v;
                        len += graph[i].weight;
                        count++;
                        join(graph[t].u, graph[t].v);
                        t++;
                    }
                }
            }
            return count;
        }

        static void get_tree(int N)
        {            
            Console.WriteLine("\nКоличесвто кабелей: {0}", build(N));
            Console.WriteLine("\nМинимальный вес: {0}", graph[0].weight);
            Console.WriteLine("\nМинимальное дерево:");
            for (int i = 1; i < N; i++)
                Console.WriteLine(tree[i, 1] + " - " + tree[i, 2]);
            
        }

        static void Main(string[] args)
        {
            int N, M, c;
            Console.Write("Выберите способ ввода данных:\n 1.Произвольная генерация\n 2.Ввод пользователя\n");
            c = int.Parse(Console.ReadLine());
            switch (c) { 
                case 1:
                    Random random = new Random();                    
                    N = random.Next(2,1000);
                    Console.WriteLine("Количество хабов: {0}", N);
                    M = random.Next(1, 15000);
                    Console.WriteLine("Количество соединений: {0}", M);

                    for (int i = 0; i < M; i++)
                    {
                        graph.Add(new edge
                        {
                            u = random.Next(1, N),
                            v = random.Next(1, N),
                            weight = random.Next(1, 100)
                        });
                   }


                    for (int j = 1; j <= N; j++)
                    { sets[j] = j; }
                    get_tree(N);
                    Console.ReadKey();
            break;
                case 2:
                    Console.Write("Введите количество хабов: ");
                    N = int.Parse(Console.ReadLine());
                    Console.Write("Введите количество соединений: ");
                    M = int.Parse(Console.ReadLine());

                    Console.WriteLine("Введите список смежностей: ");
                    for (int i = 0; i < M; i++)
                    {
                        string[] line = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                        graph.Add(new edge
                        {
                            u = int.Parse(line[0]),
                            v = int.Parse(line[1]),
                            weight = int.Parse(line[2])
                        });
                    }


                    for (int j = 1; j <= N; j++)
                    { sets[j] = j; }
                    get_tree(N);
                    Console.ReadKey();

            break;
        }
        }
    }
}
