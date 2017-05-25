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

        static int max = 10;
        static int[,] tree = new int[max, 3];
        static int[] sets = new int[max];
        static List<edge> graph = new List<edge>();
        static int N, M;                        //N - количество вершин M - количество ребер
        static double len = 0, min;

        static void add_edge()
        {
                   
            N = int.Parse(Console.ReadLine());
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}  {1}", N, M);            
            
            
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

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("u = {0} v = {1} w = {2}", graph[i].u, graph[i].v, graph[i].weight);
                Console.WriteLine("\n");
            }

            for (int j = 1; j <= N; j++) 
            { sets[j] = j; }
        }

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
            min = graph[0].weight;
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

        static void BuildTree()
        {
            int i, t = 1;
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
        }

        static void DisplayTree()
        {
            Console.WriteLine("Min weight: {0}", min);
            Console.WriteLine("Cost: {0}", len);
            Console.WriteLine("The Edges of the Minimum Spanning Tree are:");
            for (int i = 1; i < N; i++)
                Console.WriteLine(tree[i, 1] + " - " + tree[i, 2]);
            
        }

        static void Main(string[] args)
        {
            add_edge();
            BuildTree();
            DisplayTree();
            Console.ReadKey();
        }
    }
}
