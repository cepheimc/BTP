using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labor2
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite army = new Composite("Армия");

            army.Add(new Leaf("Эльфи"));
            army.Add(new Leaf("Драконы"));

            Composite comp1 = new Composite("Отряд эльфов");

            comp1.Add(new Leaf("Эльф 1"));
            comp1.Add(new Leaf("Отряд эльфов 2"));
            army.Add(comp1);
            Composite comp2 = new Composite("Отряд эльфов 3");
            comp2.Add(new Leaf("Эльф 3.1"));
            comp1.Add(comp2);
            army.Add(new Leaf("Минотавры"));

            Leaf leaf = new Leaf("Рыцари");
            army.Add(leaf);

            army.Display(1);

            Console.Read();
        }
    }
}


abstract class Component
{
    protected string name;

    public Component(string name)
    {
        this.name = name;
    }

    public virtual void Add(Component comp) { }

    public virtual void Remove(Component comp) { }

    public virtual void Display(int depth)
    {
        Console.WriteLine(name);
    }
}



class Composite : Component
{
    private List<Component> children = new List<Component>();

    public Composite(string name)
        : base(name)
    {
    }

    public void Add(Component component)
    {
        children.Add(component);
    }

    public void Remove(Component component)
    {
        children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String(' ', depth) + name);
       // Console.WriteLine("    ");
        for (int i = 0; i < children.Count; i++)
        {
            children[i].Display(depth + 2);
        }
    }
}


class Leaf : Component
{
    public Leaf(string name)
        : base(name)
    {
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new String(' ', depth) + name);
    }
}