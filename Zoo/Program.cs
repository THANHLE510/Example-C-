using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Animal
    {
        protected int weight;
        protected string name;

        public void SetMe(int weight, string name)
        {
            this.weight = weight;
            this.name = name;
        }

        public virtual void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);
        }
    }

    class Lion : Animal
    {
        public Lion(int weight, string name)
        {
            base.SetMe(weight, name);
        }
    }

    class Tiger : Animal
    {
        public Tiger(int weight, string name)
        {
            base.SetMe(weight, name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Tiger tiger = new Tiger(100, "tiger");
            Lion lion = new Lion(200, "lion");

            tiger.Show();
            lion.Show();
            
        }
    }
}
