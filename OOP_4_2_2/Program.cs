using System;

namespace OOP_4_2
{
    class Point
    {
        protected int x;
        protected int y;

        public Point() // конструктор 1
        {
            x = y = 0;
        }

        public Point(int x, int y) // конструктор 2
        {
            this.x = x;
            this.y = y;
        }

        public Point(Point a) // конструктор 3
        {
            X = a.X;
            Y = a.Y;
        }

        public int X 
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { x = value; }
        }

        public void Print() // метод
        {
            Console.WriteLine("x = {0}, y = {1}", x, y);
        }

        public static double Distance (Point a, Point b)
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }
    }

    class Triangle : Point
    {
        private Point a;
        private Point b;
        private Point c;

        public Point A
        {
            get { return a; }
            set { a = value; }
        }

        public Point B
        {
            get { return b; }
            set { b = value; }
        }

        public Point C
        {
            get { return c; }
            set { c = value; }
        }

        public Triangle(Point a, Point b, Point c) // конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public static new double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public void Length() // метод
        {
            double length = Distance(a, b) + Distance(b, c) + Distance(c, a);
            Console.WriteLine("Периметр трикутника: {0:f2}", length);
        }
    }

    class Quadrilateral : Point
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;

        public Point D
        {
            get { return d; }
            set { d = value; }
        }

        public Quadrilateral(Point a, Point b, Point c, Point d) // конструктор
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public static new double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public void Length() // метод
        {
            double length = Distance(a, b) + Distance(b, c) + Distance(c, d) + Distance(d, a);
            Console.WriteLine("Периметр чотирикутника: {0:f2}", length);
        }
    }

    class Pentagon : Point
    {
        private Point a;
        private Point b;
        private Point c;
        private Point d;
        private Point e;

        public Point E
        {
            get { return e; }
            set { e = value; }
        }

        public Pentagon(Point a, Point b, Point c, Point d, Point e)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.e = e;
        }

        public static new double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public void Length() // метод
        {
            double length = Distance(a, b) + Distance(b, c) + Distance(c, d) + Distance(d, e) + Distance(e, a);
            Console.WriteLine("Периметр п'ятикутника: {0:f2}", length);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Point a = new Point(2, 2);
            Point b = new Point(1, 5);
            Point c = new Point(3, 8);
            Point d = new Point(4, 7);
            Point e = new Point(5, 3);

            a.Print();
            b.Print();
            c.Print();
            d.Print();
            e.Print();

            Triangle triangle = new Triangle(a, b, c);
            triangle.A.Y = 1; // зміна координати y точки a
            triangle.Length();

            Quadrilateral quadrilateral = new Quadrilateral(a, b, c, d);
            quadrilateral.Length();

            Pentagon pentagon = new Pentagon(a, b, c, d, e);
            pentagon.E.Y = 4; // зміна координати y точки e
            pentagon.Length();

            Console.ReadLine();
        }
    }
}