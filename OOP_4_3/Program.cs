using System;
using System.Data;
using System.Diagnostics;

namespace OOP_4_3
{
    public class Rectangle
    {
        private int a; // поля, а і b - сторони прямокутника
        private int b;
        public const double PI = 3.1415;

        public Rectangle(int a, int b) // конструктор з параметрами 
        {
            this.a = a;
            this.b = b;
        }

        public int A // властивості
        {
            get { return a; }
            set
            {
                if (value > 0)
                {
                    a = value;
                }
            }
        }

        public int B
        {
            get { return b; }
            set
            {
                if (value > 0)
                {
                    b = value;
                }
            }
        }

        public virtual double Square() // метод обчислення площі прямокутника
        {
            return a * b;
        }
    }

    public class Trapezium : Rectangle
    {
        private int h; // висота трапеції

        public Trapezium(int a, int b, int h) : base(a, b) // конструктор з параметрами 
        {
            this.h = h;
        }

        public int H // властивость
        {
            get { return h; }
            set
            {
                if (value > 0)
                {
                    h = value;
                }
            }
        }

        public override double Square() // перевизначений метод обчислення площі трапеції
        {
            return (double)(A + B) * h / 2;
        }
    }

    public class Parallelogram : Rectangle
    {
        private double alpha; // кут альфа (у градусах) між сторонами а і b паралелограма

        public Parallelogram(int a, int b, double alpha) : base(a, b) // конструктор з параметрами 
        {
            this.alpha = alpha;
        }

        public double Alpha
        {
            get { return alpha; }
            set
            {
                if (value > 0 && value < 90)
                {
                    alpha = value;
                }
            }
        }

        public override double Square() // перевизначений метод обчислення площі паралелограма
        {
            return A * B * Math.Sin(alpha / 180 * Math.PI);
        }
    }

    public class Prizm : Rectangle
    {
        private int c; // третя сторона трикутника abc, який є основою призми
        private int f; // висота призми

        public Prizm(int a, int b, int c, int f) : base(a, b) // конструктор з параметрами 
        {
            this.c = c;
            this.f = f;
        }

        public int C
        {
            get { return c; }
            set
            {
                if (value > 0)
                {
                    c = value;
                }
            }
        }

        public int F
        {
            get { return f; }
            set
            {
                if (value > 0)
                {
                    f = value;
                }
            }
        }

        public override double Square() // перевизначений метод обчислення площі поверхні призми з трикутником в основі
        {
            double p = (A + B + c) / 2; // полупериметр трикутника
            return 2 * Math.Sqrt(p * (p - A) * (p - B) * (p - c)) + 2 * p * f;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Rectangle rectangle = new Rectangle(5, 3);
            rectangle.A = 3;
            Console.WriteLine($"Площа прямокутника: {rectangle.Square()}");

            Trapezium trapezium = new Trapezium(5, 3, 7);
            trapezium.A = 3;
            Console.WriteLine("Площа трапеції: {0:f1}", trapezium.Square());

            Parallelogram parallelogram = new Parallelogram(5, 3, 60);
            Console.WriteLine("Площа паралелограма: {0:f2}", parallelogram.Square());

            Prizm prizm = new Prizm(5, 3, 6, 8);
            Console.WriteLine("Площа поверхні призми: {0:f2}", prizm.Square());

            Console.ReadLine();
        }
    }
}