using System;

namespace OOP_4_2
{
    struct Point
    {
        private int _x;
        private int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _x = value; }
        }
    }

    class Line
    {
        public Point _a, _b, _c; // поля

        public Point A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Point B
        {
            get { return _b; }
            set { _b = value; }
        }

        public Point C
        {
            get { return _c; }
            set { _c = value; }
        }

        public Line() { } // конструктор без параметрів

        public Line(Point a, Point b, Point c) // конструктор з параметрами
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public static double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public virtual void LengthLine() // метод
        {
            double lengthLine = Distance(_a, _b) + Distance(_b, _c);
            Console.WriteLine("Довжина лінії abc: {0:f2}", lengthLine);
        }
    }

    class Triangle : Line
    {
        public Triangle(Point a, Point b, Point c) // конструктор
        {
            _a = a;
            _b = b;
            _c = c;
        }

        public static new double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public override void LengthLine() // метод
        {
            double lengthLine = Distance(_a, _b) + Distance(_b, _c) + Distance(_c, _a);
            Console.WriteLine("Периметр трикутника: {0:f2}", lengthLine);
        }
    }

    class Quadrilateral : Line
    {
        public Point _d; // поле

        public Point D
        {
            get { return _d; }
            set { _d = value; }
        }

        public Quadrilateral(Point a, Point b, Point c, Point d) // конструктор
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
        }

        public static new double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public override void LengthLine() // метод
        {
            double lengthLine = Distance(_a, _b) + Distance(_b, _c) + Distance(_c, _d) + Distance(_d, _a);
            Console.WriteLine("Периметр чотирикутника: {0:f2}", lengthLine);
        }
    }

    class Pentagon : Line
    {
        public Point _d; // поля
        public Point _e;

        public Point E
        {
            get { return _e; }
            set { _e = value; }
        }

        public Pentagon(Point a, Point b, Point c, Point d, Point e)
        {
            _a = a;
            _b = b;
            _e = c;
            _d = d;
            _e = e;
        }

        public static new double Distance(Point a, Point b) // метод
        {
            return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(a.Y - b.Y, 2));
        }

        public override void LengthLine() // метод
        {
            double lengthLine = Distance(_a, _b) + Distance(_b, _c) + Distance(_c, _d) + Distance(_d, _e) + Distance(_e, _a);
            Console.WriteLine("Периметр п'ятикутника: {0:f2}", lengthLine);
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

            Line line = new Line(a, b, c);
            line.LengthLine();

            Point e = new Point(5, 3);

            Triangle triangle = new Triangle(a, b, c);
            triangle.LengthLine();

            Quadrilateral quadrilateral = new Quadrilateral(a, b, c, d);
            quadrilateral.LengthLine();

            Pentagon pentagon = new Pentagon(a, b, c, d, e);
            pentagon.LengthLine();

            Console.ReadLine();
        }
    }
}