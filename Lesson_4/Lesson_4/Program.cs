using System;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Reflection;
        } 
    }

namespace ConsoleAppSY
    {
        abstract class Figure
        {
            readonly int xxx;
            readonly int yyy;
            public Figure(int xxx, int yyy)
            {
                this.xxx = xxx;
                this.yyy = yyy;
            }
            public abstract void Draw();
        }
        class Square : Figure
        {
            public Square(int aaa) : base(aaa, aaa) { }
            public override void Draw()
            {
                Console.WriteLine("Draw Square");
            }
        }
        class Rectangle : Figure
        {
            public Rectangle(int xxx, int yyy) : base(xxx, yyy) { }
            public override void Draw()
            {
                Console.WriteLine("Draw Rectangle");
            }
        }
        public static class Program
        {
            public static void Main()
            {
                Console.WriteLine("Enter side1 and side2");
                Console.WriteLine("side1: ");
                int _x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("side2: ");
                int _y = Convert.ToInt32(Console.ReadLine());
                Square a = new Square(_x);
                a.Draw();
                Rectangle b = new Rectangle(_x, _y);
                b.Draw();

            }
        }
    }

}
    

