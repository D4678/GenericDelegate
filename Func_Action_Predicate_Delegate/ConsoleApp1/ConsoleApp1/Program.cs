using System;

namespace ConsoleApp1
{
    public class GenericDelegate
    {
        //public delegate double Delegate1(int x, float y, double z);
        //public delegate void Delegate2(int x, float y, double z);
        //public delegate bool Delegate3(string str);

        //public static double AddNums1(int x, float y, double z)
        //{
        //    return x + y + z;
        //}

        //public static void AddNums2(int x, float y, double z)
        //{
        //    Console.WriteLine(x + y + z);
        //}

        //public static bool CheckLength(string str)
        //{
        //    if (str.Length > 5)
        //        return true;
        //    return false;
        //}

        public static void Main()
        {
            Func<int,float,double,double> Obj1 = (x,y,z) => { return x + y + z; };
            double result = Obj1.Invoke(100, 34.5f, 193.546);
            Console.WriteLine(result);

            Action<int, float, double> Obj2 = (x, y, z) => { Console.WriteLine(x + y + z); };
            Obj2.Invoke(100, 34.5f, 193.546);

            //Delegate3 Obj3 = CheckLength;
            Predicate<string> Obj3 = (str) =>
            {
                if (str.Length > 5)
                    return true;
                return false;
            };
            bool status = Obj3.Invoke("Hello World");
            Console.WriteLine(status);
        }
    }
}