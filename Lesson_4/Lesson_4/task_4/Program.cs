using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args);
        
            public class Figure
        {
            readonly double xxx, yyy;

            public Figure(double xxx, double yyy)
            {
                this.xxx = xxx;
                this.yyy = yyy;
            }
            public virtual void Draw() { }
        }

        class Square : Figure
        {
            public Square(double aaa) : base(aaa, aaa) { }
            public override void Draw()
            {
                base.Draw();
                Console.WriteLine("Draw square");
            }
        }
        class Rectangle : Figure
        {
            public Rectangle(double xxx, double yyy) : base(xxx, yyy) { }
            public override void Draw()
            {
                base.Draw();
                Console.WriteLine("Draw Rectangle");
            }
        }
        public static class Program
        {
            static void Main()
            {
                Console.WriteLine("Enter side1 and side2");
                Console.WriteLine("side1: ");
                double _x = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("side2: ");
                double _y = Convert.ToDouble(Console.ReadLine());
                Square a = new Square(_x);
                a.Draw();
                Rectangle b = new Rectangle(_x, _y);
                b.Draw();
            }
        }

    }
}

