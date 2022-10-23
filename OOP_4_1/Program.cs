using System;

namespace OOP_4_1
{
    public class Rectangle
    {
        private int a; // поля, а і b - сторони прямокутника
        private int b;
        public const string type1 = "Rectangle";

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

        public double Square() // метод обчислення площі прямокутника
        {
            return a * b;
        }

        public int Perimeter() // метод обчислення периметра прямокутника
        {
            return 2 * (a + b);
        }
    }
    public class RParallelepiped : Rectangle
    {
        private int c; // поле, с - висота прямокутного паралелепіпеда 
        public const string type2 = "RecParallelepiped";

        // конструктор з параметрами
        public RParallelepiped(int a, int b, int c) : base(a, b)
        {
            this.c = c;
        }

        public int C // властивість C
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

        // перевизначений метод для обчислення площі поверхні прямокутного паралелепіпеда
        public new double Square()
        {
            return Perimeter() * c + 2 * base.Square();
        }
    }
    public class Pyramid : Rectangle
    {
        public int c; // поле, с - висота прямокутного паралелепіпеда 
        public const string type3 = "Pyramid";

        // конструктор з параметрами
        public Pyramid(int a, int b, int c) : base(a, b)
        {
            this.c = c;
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

        // перевизначений метод для обчислення площі поверхні піраміди
        public new double Square()
        {
            return A * Math.Sqrt(c * c + B * B / 4) + B * Math.Sqrt(c * c + A * A / 4) + base.Square();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Rectangle rectangle = new Rectangle(5, 4);

            rectangle.A = 3;

            Console.WriteLine($"Площа прямокутника: {rectangle.Square()}");
            Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter()}");

            RParallelepiped rP = new RParallelepiped(3, 4, 6);

            Console.WriteLine($"Площа поверхні прямокутного паралелепіпеда: {rP.Square()}");

            Pyramid pyramid = new Pyramid(2, 3, 7);

            Console.WriteLine("Площа поверхні піраміди: {0:f2}", pyramid.Square());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(Rectangle.type1);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(RParallelepiped.type2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Pyramid.type3);

            Console.ReadLine();
        }
    }
}