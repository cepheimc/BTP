using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Chef chefD = new Chef();
            Chef chefS = new Chef();         
            Console.WriteLine("На завтрак клиент выбрал:");
            MenuBuilder e = new Egg();
            SecondDish egg = chefD.chefDish(e);
            Console.WriteLine(egg.ToString());
            Console.WriteLine("На обед клиент выбрал:");
            MenuBuilder b = new Borsch();
            Soup bor = chefS.chefSoup(b);
            Console.WriteLine(bor.ToString());
            MenuBuilder p = new Puree();
            SecondDish pur = chefD.chefDish(p);
            Console.WriteLine(pur.ToString());
            Console.WriteLine("На ужин клиент выбрал:");
            MenuBuilder w = new BuckWheat();
            SecondDish wheat = chefD.chefDish(w);
            Console.WriteLine(wheat.ToString());
            MenuBuilder d = new Dessert();
            SecondDish dess = chefD.chefDish(d);
            Console.WriteLine(dess.ToString());
            Console.Read();

        }
    }

}
