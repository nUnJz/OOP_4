using System;

namespace OOP_4_3
{
    class Worker
    {
        private string firstname;
        private string lastname;
        private double salary;
        //private double premium;
        private double bonus;
        //private int detailsQuantity;


        public string FirstName // властивості
        {
            get { return firstname; }
            set { firstname = value; }
        }

        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        /*public double Premium
        {
            get { return premium; }
            set
            {
                if (premium >= 0 && premium < 1)
                {
                    premium = value;
                }
            }
        }*/

        public double Bonus
        {
            get { return bonus; }
            set
            {
                if (bonus >= 0 && bonus < 1)
                {
                    bonus = value;
                }
            }
        }

        /*public int DetailsQuantity
        {
            get { return detailsQuantity; }
            set { detailsQuantity = value; }
        }*/

        public Worker() // конструктор без параметрів
        {
            firstname = "empty";
            lastname = "empty";
            salary = 0.0;
            //premium = 0.0;
            bonus = 0.0;
            //detailsQuantity = 0;
        }

        public Worker(string fname, string lname, double salary, double bonus) // конструктор з параметрами
        {
            firstname = fname;
            lastname = lname;
            this.salary = salary;
            //this.premium = premium;
            this.bonus = bonus;
            //detailsQuantity = dQuantity;
        }

        public virtual void Print()
        {
            Console.WriteLine("{0} {1}, {2} грн., {3}", lastname, firstname, salary, bonus);
        }

        public virtual double GetBonusSum(double bonus)
        {
            return bonus * salary;
        }

        public virtual double GetFullSum()
        {
            return salary + GetBonusSum(bonus);
        }

        /*public virtual void GiveBonus(double bonus)
        {
            salary += salary * bonus;
            Console.WriteLine(salary);
        }*/
    }

    class SalesPerson : Worker
    {
        private int salesQuantity; // обсяги продажів здійснені торговим агентом

        public int SalesQuantity
        {
            get { return salesQuantity; }
            set { salesQuantity = value; }
        }

        public SalesPerson(string fname, string lname, double salary, double bonus, int sQuantity) : base(fname, lname, salary, bonus)
        {
            salesQuantity = sQuantity;
        }

        public override void Print()
        {
            Console.WriteLine("{0} {1}, {2} грн., {3}, {4}", LastName, FirstName, Salary, Bonus);
        }

        public override double GetBonusSum(double bonus)
        {
            return bonus * Salary;
        }

        public override double GetFullSum()
        {
            return Salary + GetBonusSum(Bonus);
        }

        /*public override void GiveBonus(double bonus)
        {
            if (salesQuantity > 100)
            {
                bonus += bonus * 0.1;
                Salary += bonus;
            }
        }*/
    }

    /*class Manager : Worker
    {
        private int contractQuantity;

        public int СontractQuantity
        {
            get { return contractQuantity; }
            set { contractQuantity = value; }
        }

        public Manager(string firstname, string lastname, double salary, double bonus, int contractQuantity) : base(firstname, lastname, salary, bonus)
        {
            this.contractQuantity = contractQuantity;
        }

        public override void GiveBonus(double bonus)
        {
            if (contractQuantity > 10)
            {
                bonus += bonus * 0.15;
                Salary += bonus;
            }
        }
    }

    class Employer : Worker
    {
        private int workExperience;

        public int WorkExperience
        {
            get { return workExperience; }
            set { workExperience = value; }
        }

        public Employer(string firstname, string lastname, double salary, double bonus, int workExperience) : base(firstname, lastname, salary, bonus)
        {
            this.workExperience = workExperience;
        }

        public override void GiveBonus(double bonus)
        {
            if (workExperience > 10)
            {
                bonus += bonus * 0.02;
                Salary += bonus;
            }

            if (workExperience > 20)
            {
                bonus += bonus * 0.05;
                Salary += bonus;
            }
        }
    }*/

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Worker worker1 = new Worker("Петро", "Харченко", 12000, 0.08);
            worker1.GetBonusSum(0.08);
            worker1.GetFullSum();
            worker1.Print();
            Console.WriteLine("Повна сума зарплати:", worker1.GetFullSum());

            SalesPerson salesPerson = new SalesPerson("Іван", "Донченко", 15000, 0.1, 110);
            salesPerson.Print();

            Console.ReadLine();
        }
    }
}
