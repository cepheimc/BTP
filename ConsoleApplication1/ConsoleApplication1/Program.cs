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
            double len = 0;
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
                        join(graph[t].u, graph[t].v);
                        t++;
                    }
                }
            }
            return len;
        }

        static void get_tree(int N)
        {            
            Console.WriteLine("Cost: {0}", build(N));
            Console.WriteLine("Min weight: {0}", graph[0].weight);
            Console.WriteLine("Minimum tree:");
            for (int i = 1; i < N; i++)
                Console.WriteLine(tree[i, 1] + " - " + tree[i, 2]);
            
        }

        static void Main(string[] args)
        {
            int N, M;
            Console.Write("Введите количество вершин: ");
            N = int.Parse(Console.ReadLine());
            Console.Write("Введите количество ребер: ");
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
        }
    }
}
