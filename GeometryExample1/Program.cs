using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
    public abstract class Cylinder
    {
        protected double Radius { get; set; }
        protected double Height { get; set; }
        protected double BaseArea { get; set; }
        protected double LateralArea { get; set; }
        protected double TotalArea { get; set; }
        protected double Volume { get; set; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public abstract void Process();

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics ");
            Console.WriteLine($"Radius:{Radius}, Height: {Height} ");
            Console.WriteLine($"Base: {BaseArea}  ; Lateral: {LateralArea}  ;  Total: {TotalArea}  ;  Volume: {Volume}");
        }
    }

    public class ConcreteCylinder : Cylinder
    {
        public ConcreteCylinder(double radius, double height) : base(radius, height)
        {
        }

        public override void Process()
        {
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            double radius, height;

        Console.WriteLine("Enter the dimensions of the cylinder");
        Console.Write("Radius: ");
        radius = Convert.ToDouble(Console.ReadLine());
        Console.Write("Height: ");
        height = Convert.ToDouble(Console.ReadLine());

        ConcreteCylinder cylinder = new ConcreteCylinder(radius, height);
        cylinder.Process();
        cylinder.Result();
        }
    }
}
