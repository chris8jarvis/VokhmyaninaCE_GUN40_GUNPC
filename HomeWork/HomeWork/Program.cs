using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;

namespace HomeWork
{

    class MusicalInstrument
    {

        public string name;
        private int cost;

        public MusicalInstrument(string name, int cost)
        {
            this.name = name;
            Cost = cost;
        }
        public MusicalInstrument()
        {
           this.name = "Noname";
            Cost = 999;
        }

        public void Print()
        {
            Console.WriteLine($"You chose {name} which cost {cost}");
        }

        public int Cost
        {
            set
            {
                if (value >= 1000 && value <= 50000)
                {
                    cost = value;
                }
                else
                {
                    Console.WriteLine("Inadequate cost for item");
                }
            }
            get
            {
                return cost;
            }
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstrument ukulele = new MusicalInstrument();

            //Console.WriteLine($"Ukulele cost: {ukulele.Cost}");
            ukulele.Print();

            ukulele.Cost = 5000;
            Console.WriteLine($"Ukulele cost: {ukulele.Cost}");
            ukulele.Cost = 20;
            Console.WriteLine($"Ukulele cost: {ukulele.Cost}");

            //string instrumentOne = ukulele.name;
            //int instrumentOneCost = ukulele.cost;
            //ukulele.name = "ukulele";
            //ukulele.cost = 8;
            //ukulele.Print();


            MusicalInstrument drums = new MusicalInstrument("Drums dd7 black", 777);
            Console.WriteLine($"Drums cost: {drums.Cost}");
            drums.Cost = 50000000;
            Console.WriteLine($"Drums cost: {drums.Cost}");
            drums.Cost = 20000;
            Console.WriteLine($"Drums cost: {drums.Cost}");

            //string instrumentTwo = drums.name;
            //int instrumentTwoCost = drums.cost;
            //drums.name = "drums";
            //drums.cost = 20000;
            //drums.Print();
        }

    }

    //class Test
    //{
    //    public int Field;
    //    private float property;

    //    public float Property
    //    {
    //        get
    //        {
    //            if (property == 0f)
    //            {
    //                return 1f;
    //            }
    //            return property;
    //        }
    //        set
    //        {
    //            if (property < 0f)
    //            {
    //                Console.WriteLine("Trying to get negative value to property");
    //                return;
    //            }
    //            property = value;
    //        }
    //    }

    //    public void someMethod(int number)
    //    {
    //        Console.WriteLine($"Method works: {number}");
    //    }

    //    public Test() //конструктор инициализирует значения полей
    //    {
    //        Property = 10f;
    //    }

    //    public Test(int number)
    //    {
    //        Field = number;
    //    }

    //    public Test(float number)
    //    {
    //        Property = number;
    //        someMethod(1000);
    //    }

    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var object1 = new Test();
    //        var object2 = new Test(4774);
    //        var object3 = new Test(417.12f);

    //        Console.WriteLine(" object 1 field value = {0} and object2 = {1}", object1.Field, object2.Field);

    //    }
    //}
}
