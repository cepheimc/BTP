using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Vegetables
    {
        public string sort { get; set; }
    }

    class Meat
    {
        public string type { get; set; }
    }

    class Salt
    { }

    class Porridge
    {
        public string type { get; set; }
    }

    class Soup
    {
        public Vegetables Veg { get; set; }
        public Meat Meat { get; set; }
        public Salt Salt { get; set; }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (Veg != null)
                s.Append(Veg.sort + "\n");
            if (Meat != null)
                s.Append(Meat.type + "\n");
            if (Salt != null)
                s.Append("Соль\n");
            return s.ToString();

        }
    }

    class SecondDish
    {
        public Porridge Porr { get; set; }
        public Meat Meat { get; set; }
        public Salt Salt { get; set; }
        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            if (Porr != null)
                s.Append(Porr.type + "\n");
            if (Meat != null)
                s.Append(Meat.type + "\n");
            if (Salt != null)
                s.Append("Соль\n");
            return s.ToString();

        }
    }

   abstract class MenuBuilder
    {
       public Soup Soup { get; set; }
       public SecondDish Dish { get; set; }
       public void CreateMenu()
       {
           Soup = new Soup();
           Dish = new SecondDish();
       }
       public abstract void GetName();
       public abstract void SetVeg();
       public abstract void SetMeat();
       public abstract void SetSalt();
       public abstract void SetPorridge();

    }



    class Chef
    {
        public Soup chefSoup(MenuBuilder menu)
        {
            menu.CreateMenu();
            menu.SetMeat();
            menu.SetVeg();
            menu.SetSalt();
            menu.GetName();
            return menu.Soup;

        }

        public SecondDish chefDish(MenuBuilder menu)
        {
            menu.CreateMenu();
            menu.SetMeat();
            menu.SetPorridge();
            menu.SetSalt();
            menu.GetName();
            return menu.Dish;

        }
    }

    class Borsch : MenuBuilder
    {
        public override void GetName()
        {
            Console.WriteLine("Борщ:");
        }
        public override void SetVeg()
        {
            this.Soup.Veg = new Vegetables { sort = "Капуста, буряк, картошка, лук, морковка." };
        }
        public override void SetMeat()
        {
            this.Soup.Meat = new Meat { type = "Свинина." };
        }
        public override void SetSalt()
        {
            this.Soup.Salt = new Salt();
        }
        public override void SetPorridge()
        {
            
        }
    }

    class Veget : MenuBuilder
    {
        public override void GetName()
        {
            Console.WriteLine("Овощной:");
        }
        public override void SetVeg()
        {
            this.Soup.Veg = new Vegetables { sort = "Капуста, буряк, картошка, лук, морковка." };
        }
        public override void SetMeat()
        {       }
        public override void SetSalt()
        {
            this.Soup.Salt = new Salt();
        }
        public override void SetPorridge()
        {   }
    }

    class SaltWort : MenuBuilder
    {
        public override void GetName()
        {
            Console.WriteLine("Солянка:");
        }
        public override void SetVeg()
        {
            this.Soup.Veg = new Vegetables { sort = "Оливки, лимон, картошка, лук, морковка." };
        }
        public override void SetMeat()
        {
            this.Soup.Meat = new Meat { type = "Копченная свинина." };
        }
        public override void SetSalt()
        {
            this.Soup.Salt = new Salt();
        }
        public override void SetPorridge()
        {   }
    }
    class Puree : MenuBuilder
    {
        public override void GetName()
        { }
        public override void SetPorridge()
        {
            this.Dish.Porr = new Porridge { type = "Картошка пюре." };
        }
        public override void SetMeat()
        {
            this.Dish.Meat = new Meat { type = "Свинина." };
        }
        public override void SetSalt()
        {
            this.Dish.Salt = new Salt();
        }
        public override void SetVeg()
        {   }
    }

    class BuckWheat : MenuBuilder
    {
        public override void GetName()
        { }
        public override void SetPorridge()
        {
            this.Dish.Porr = new Porridge { type = "Гречка." };
        }
        public override void SetMeat()
        {
            this.Dish.Meat = new Meat { type = "Мясо по-французки." };
        }
        public override void SetSalt()
        {
            this.Dish.Salt = new Salt();
        }
        public override void SetVeg()
        {   }
    }

    class Egg : MenuBuilder
    {
        public override void GetName()
        { }
        public override void SetPorridge()
        {
            this.Dish.Porr = new Porridge { type = "Омлет" };
        }
        public override void SetMeat()
        {  }
        public override void SetSalt()
        {
            this.Dish.Salt = new Salt();
        }
        public override void SetVeg()
        {  }
    }

    class Dessert : MenuBuilder
    {
        public override void GetName()
        { }
        public override void SetPorridge()
        {
            this.Dish.Porr = new Porridge { type = "Сырники с джемом." };
        }
        public override void SetMeat()
        {      }
        public override void SetSalt()
        {       }
        public override void SetVeg()
        {  }
    }
}
