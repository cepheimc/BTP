using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;


namespace lab6_EF
{
    class Program
    {
        
        static void addRouteAndStation()
        {
            RouteContainer db = new RouteContainer();
            db.Routes.Add(new Route()
            {
                count = "4"
            });
            db.Routes.Add(new Route()
            {
                count = "2"
            });
            db.Routes.Add(new Route()
            {
                count = "4"
            });
            db.Stations.Add(new Station()
                {
                name = "station1"
                });
            db.Stations.Add(new Station()
            {
                name = "station2"
            });
            db.Stations.Add(new Station()
            {
                name = "station3"
            });
            db.Stations.Add(new Station()
            {
                name = "station4"
            });
            db.Stations.Add(new Station()
            {
                name = "station5"
            });
            db.Stations.Add(new Station()
            {
                name = "station6"
            });
            
           db.SaveChanges();
        }

        static void addBus()
        {
            RouteContainer db = new RouteContainer();
            Route r1 = db.Routes.Where(r => r.Id == 1).FirstOrDefault();
            Route r2 = db.Routes.Where(r => r.Id == 2).FirstOrDefault();
            Route r3 = db.Routes.Where(r => r.Id == 3).FirstOrDefault();
            db.Buss.Add(new Bus()
            {
                number = "1",
                Route = r1,
                RouteId = 1
            });
            db.Buss.Add(new Bus()
            {
                number = "2",
                Route = r1,
                RouteId = 1
            });
            db.Buss.Add(new Bus()
            {
                number = "3",
                Route = r1,
                RouteId = 1
            });
            db.Buss.Add(new Bus()
            {
                number = "4",
                Route = r1,
                RouteId = 1
            });
            db.Buss.Add(new Bus()
            {
                number = "1",
                Route = r2,
                RouteId = 2
            });
            db.Buss.Add(new Bus()
            {
                number = "2",
                Route = r2,
                RouteId = 2
            });
            db.Buss.Add(new Bus()
            {
                number = "1",
                Route = r3,
                RouteId = 3
            });
            db.Buss.Add(new Bus()
            {
                number = "2",
                Route = r3,
                RouteId = 3
            });
            db.Buss.Add(new Bus()
            {
                number = "3",
                Route = r3,
                RouteId = 3
            });
            db.Buss.Add(new Bus()
            {
                number = "4",
                Route = r3,
                RouteId = 3
            });
            db.SaveChanges();
        }

        static void addLink()
        {
            RouteContainer db = new RouteContainer();
            Route r1 = db.Routes.Where(r => r.Id == 1).FirstOrDefault();
            Route r2 = db.Routes.Where(r => r.Id == 2).FirstOrDefault();
            Route r3 = db.Routes.Where(r => r.Id == 3).FirstOrDefault();
            Station s1 = db.Stations.Where(s => s.Id == 1).FirstOrDefault();
            Station s2 = db.Stations.Where(s => s.Id == 2).FirstOrDefault();
               Station s3 = db.Stations.Where(s => s.Id == 3).FirstOrDefault();
              Station s4 = db.Stations.Where(s => s.Id == 4).FirstOrDefault();
              Station s5 = db.Stations.Where(s => s.Id == 5).FirstOrDefault();
               Station s6 = db.Stations.Where(s => s.Id == 6).FirstOrDefault();
               db.Links.Add(new Link()
               {
                   time = "10",
                   Route = r1,
                   Station = s1,
                   Station1 = s2
               });
               db.Links.Add(new Link()
               {
                   time = "7",
                   Route = r1,
                   Station = s3,
                   Station1 = s4
               });
               db.Links.Add(new Link()
               {
                   time = "3",
                   Route = r2,
                   Station = s4,
                   Station1 = s5
               });
               db.Links.Add(new Link()
               {
                   time = "9",
                   Route = r2,
                   Station = s6,
                   Station1 = s5
               });
               db.Links.Add(new Link()
               {
                   time = "6",
                   Route = r3,
                   Station = s1,
                   Station1 = s4
               });
               db.Links.Add(new Link()
               {
                   time = "5",
                   Route = r3,
                   Station = s4,
                   Station1 = s2
               });
            db.SaveChanges();

        }

        static void addLinkAndStations()
        {
            RouteContainer db = new RouteContainer();
            Link l1 = db.Links.Where(r => r.Id == 1).FirstOrDefault();
            Link l2 = db.Links.Where(r => r.Id == 2).FirstOrDefault();
            Link l3 = db.Links.Where(r => r.Id == 3).FirstOrDefault();
            Link l4 = db.Links.Where(r => r.Id == 4).FirstOrDefault();
            Link l5 = db.Links.Where(r => r.Id == 5).FirstOrDefault();
            Link l6 = db.Links.Where(r => r.Id == 6).FirstOrDefault();
            Station s1 = db.Stations.Where(s => s.Id == 1).FirstOrDefault();
            Station s2 = db.Stations.Where(s => s.Id == 2).FirstOrDefault();
            Station s3 = db.Stations.Where(s => s.Id == 3).FirstOrDefault();
            Station s4 = db.Stations.Where(s => s.Id == 4).FirstOrDefault();
            Station s5 = db.Stations.Where(s => s.Id == 5).FirstOrDefault();
            Station s6 = db.Stations.Where(s => s.Id == 6).FirstOrDefault();

            s1.Linkss.Add(l1);
            s1.Linkss.Add(l2);
            s2.Linkss.Add(l3);
            s3.Linkss.Add(l3);
            s3.Linkss.Add(l5);
            s4.Linkss.Add(l6);
            s5.Linkss.Add(l1);
            s5.Linkss.Add(l3);
            s5.Linkss.Add(l6);
            s6.Linkss.Add(l4);
            l1.Stationss.Add(s1);
            l2.Stationss.Add(s1);
            l3.Stationss.Add(s2);
            l3.Stationss.Add(s3);
            l5.Stationss.Add(s3);
            l6.Stationss.Add(s4);
            l1.Stationss.Add(s5);
            l3.Stationss.Add(s5);
            l6.Stationss.Add(s5);
            l4.Stationss.Add(s6);
            db.Stations.Attach(s1);
            db.Entry(l2).State = EntityState.Modified;
            db.SaveChanges();

        }

        static void Main(string[] args)
        {
          //  addRouteAndStation();
          //  addBus();         
        //    addLink();
         //   addLinkAndStations();
            RouteContainer db = new RouteContainer();

            List<Link> l = db.Links.Select(l1 => new
                {
                    l_id = l1.RouteId,
                    l_t = l1.time,
                    l_st = l1.Stationss.Select(s => new
                    {
                        s_id = s.Id,
                        s_n = s.name
                    })

                }).AsEnumerable().Select(obj => new Link
                {
                    RouteId = obj.l_id,
                    time = obj.l_t,
                    Stationss = obj.l_st.Select(s => new Station
                    {
                        Id = s.s_id,
                        name = s.s_n
                    }).ToList()
                }).ToList();

            foreach (Link l2 in db.Links)
            {
                Console.WriteLine("номер маршрута: "+l2.RouteId + " время поездки:  " + l2.time);
                Console.WriteLine("Станции, которые есть в маршруте");
                foreach(Station s in l2.Stationss)
                {
                    Console.WriteLine("название станций: " + s.name);
                }               
            }
            Console.WriteLine("Вывести маршруты, которые не останавливаются на station1");

            var q2 = db.Links.Where(c => c.Station.Id!=1);
            foreach(Link lin1 in q2)
           {
                Console.WriteLine("номер маршрута: " + lin1.RouteId + " время поездки:  " + lin1.time);
            }
            Console.WriteLine("Вывести маршруты, время и количество станций");
            List<Link> l5 = db.Links.Select(l1 => new
            {
                l_id = l1.RouteId,
                l_t = l1.time           

            }).AsEnumerable().Select(obj => new Link
            {
                RouteId = obj.l_id,
                time = obj.l_t                
            }).ToList();

            foreach (Link l2 in db.Links)
            {
                Console.WriteLine("номер маршрута: "+l2.RouteId + " время поездки:  " + l2.time+ " количество станций: " + l2.Stationss.Count());                           
            }
            Console.WriteLine("Вывести тнформацию по маршрутам и троллейбусам");
            List<Route> l6 = db.Routes.Select(l1 => new
            {
                l_id = l1.Id,
                l_t = l1.count,
                l_st = l1.Bus.Select(s => new
                {                    
                    s_n = s.number
                })

            }).AsEnumerable().Select(obj => new Route
            {
                Id = obj.l_id,
                count = obj.l_t,
                Bus = obj.l_st.Select(s => new Bus
                {                  
                    number = s.s_n
                }).ToList()
            }).ToList();

            foreach (Route l2 in db.Routes)
            {
                Console.WriteLine("номер маршрута: "+l2.Id + " количество троллейбусов:  " + l2.count);
                foreach(Bus s in l2.Bus)
                {
                    Console.WriteLine("номер троллейбуса: " + s.number);
                }               
            }
            var q3 = db.Links;
            foreach(Link q in q3)
            {
                Console.WriteLine("номер маршрута: "+q.RouteId + " начальная станция  " + q.Station.name + " конечная станция " + q.Station1.name);
            }
            Console.ReadKey();
        }
    }
}
