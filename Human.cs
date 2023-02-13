using System;
namespace _13._02._2023LB
{
    ///////////////////////////////////////////////////

    /*public class Human
    {
        public string Name { set; get; }
        public int Age { set; get; }

        public Human() { }
        public Human(string N, int A)
        {
            Name = N;
            Age = A;
        }

        public void Show()
        {
            Console.WriteLine("Имя человека:" + Name);
            Console.WriteLine("Возраст человека:" + Age);
            Console.WriteLine("\n");
        }
    }
    public class Sailor : Human
    {
        public string Ship_Name { set; get; }

        public Sailor(string SN, string N, int A) : base(N, A)
        {
            Ship_Name = SN;
        }

        new public void Show()
        {
            base.Show();
            Console.WriteLine("Название судна:" + Ship_Name);
            Console.WriteLine("\n");
        }
    }
    public class Builder : Human
    {
        public string Company_Name { set; get; }

        public Builder(string CN, string N, int A) : base(N, A)
        {
            Company_Name = CN;
        }
        new public void Show()
        {
            base.Show();
            Console.WriteLine("Название компании:" + Company_Name);
        }
    }
    public class Pilot : Human
    {
        public string Name_Airplane { set; get; }

        public Pilot(String NA, string N, int A) : base(N, A)
        {
            Name_Airplane = NA;
        }

        new public void Show()
        {
            base.Show();
            Console.WriteLine("Название самолета:" + Name_Airplane);
            Console.WriteLine("\n");
        }
    }

    ///////////////////////////////////////////////////

    public class Pasport
    {
        public string Name_Petrson { set; get; }
        public int Age_Persone { set; get; }
        public string Country { set; get; }

        public Pasport() { }
        public Pasport(string NP, int AP, string C)
        {
            Name_Petrson = NP;
            Age_Persone = AP;
            Country = C;
        }

        public void Print()
        {
            Console.WriteLine("Имя человека:"+Name_Petrson);
            Console.WriteLine("Возраст человека:"+Age_Persone);
            Console.WriteLine("Страна:"+Country);
            Console.WriteLine("\n");
        }
    }
    public class ForeignPassport : Pasport
    {
        public string Number_ForeignPassport { set; get; }
        public string Visa_Details { set; get; }

        public ForeignPassport() { }
       
        public ForeignPassport(string NF, string VD, string NP, int AP, string C) :base(NP, AP, C)
        {
            Number_ForeignPassport = NF;
            Visa_Details = VD;
        }

        new public void Print()
        {
            base.Print();
            Console.WriteLine("Номер загран паспорта:"+Number_ForeignPassport);
            Console.WriteLine("Информация о визе:"+Visa_Details);
            Console.WriteLine("\n");
        }

    }*/

    ////////////////////////////////////////////

    /*public class Enimals
    {
        public string Name_Enimal { set; get; }
        public int Age_Enimal { set; get; }
        public int Weight { set; get; }

        public Enimals() { }

        public Enimals(string NE, int AG, int W)
        {
            Name_Enimal = NE;
            Age_Enimal= AG;
            Weight = W;
        }

        public void Printer()
        {
            Console.WriteLine("Имя животного:"+Name_Enimal);
            Console.WriteLine("Возраст животного:" + Age_Enimal);
            Console.WriteLine("Вес животного:"+Weight);
            Console.WriteLine("\n");

        }
    }
    public class Crocodil:Enimals
    {
        public int Length;

        public Crocodil() { }

        public Crocodil(int L, string NE, int AG, int W) :base( NE, AG,  W)
        {
            Length = L;
        }

        new public void Printer()
        {
            base.Printer();
            Console.WriteLine("Длина животного:" + Length);
        }
    }
    public class Tiger:Enimals
    {
        public string Sex { set; get; }

        public Tiger() { }

        public Tiger(string S, string NE, int AG, int W) : base(NE, AG, W)
        {
            Sex = S;
        }

        new public void Printer()
        {
            base.Printer();
            Console.WriteLine("Пол животного:" + Sex);
        }
    }
    public class Kangaroo:Enimals
    {
        public int Jump_Height;

        public Kangaroo() { }

        public Kangaroo(int Ju, string NE, int AG, int W) : base(NE, AG, W)
        {
            Jump_Height = Ju;
        }

        new public void Printer()
        {
            base.Printer();
            Console.WriteLine("Высота прыжка животного:" + Jump_Height);
        }
    }*/

    abstract public class Figure
    {
        public double width { set; get; }
        public double height { set; get; }

        public Figure() { }
        public Figure(double w, double h)
        {
            width = w;
            height = h;
        }

        public abstract void Square();

        public void Print()
        {
            Console.WriteLine("Ширина:"+width);
            Console.WriteLine("Высота:"+height);
        }
        public override string ToString()
        {
            return $"Ширина:{width}\t,Высота:{height}\n";
           
        }
    }
    public class Pramoug : Figure
    {
        public string Type { set; get; }

        public double Temp = 0;

        public Pramoug() { }
        public Pramoug(string T, double w, double h) : base(w, h)
        {
            Type = T;
        }

        public override void Square()
        {
            Temp = width * height;
        }

        new public void Print()
        {
            Console.WriteLine("Площадь прямоугольника = " + Temp);
        }

        public class Krug : Figure
        {
            public double Diametr { set; get; }

            public double Temp1 = 0;

            public Krug() { }
            public Krug(double D, double w, double h) : base(w, h)
            {
                Diametr = D;
            }

            public override void Square()
            {
                Temp1 = Diametr*3.14;
            }

            new public void Print()
            {
                Console.WriteLine("Площадь круга = " + Temp1);
            }
        }
        public class PramougTreug : Figure
        {
            public double L_Base { set; get; }
            public double B_Base { set; get; }
            public int Height { set; get; }

            public double Temp3 = 0;

            public PramougTreug() { }
            public PramougTreug(double L_B, double B_B, double w, double h) : base(w, h)
            {
                L_Base = L_B;
                B_Base = B_B;
            }

            public override void Square()
            {
                Temp3 = (L_Base + B_Base) / 2 * Height;
            }

            new public void Print()
            {
                Console.WriteLine("Площадь прямоугольного треугольника = " + Temp3);
            }

        }






    }

}
