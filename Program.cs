
using System.Data;
using System.Text.RegularExpressions;

namespace ConsoleApp27
{
    internal class Program
    {
        /*public delegate void MyDelegate();
        public delegate string Delegate_1(string str);*/
        public delegate bool NumberEven(int x);
        public delegate int SquareNum(int x);
        public delegate int Cube(int x);
        public delegate bool ProgramerDay(int day, int month);
        public delegate int Max(int[] arr);
        public delegate int Min(int[] arr);
        public delegate void Seach(int[] num);
        static void Main(string[] args)
        {
            /*var classB = new ClassB();
            MyDelegate delA = classB.Show;
            delA();
            Delegate_1 del_1 = delegate (string str)
            {
                Console.WriteLine(str);
                return str;
            };
            del_1("Hello");
            Delegate_1 del_2 = (str) =>
            {
                Console.WriteLine(str);
                return str;
            };
            del_2("Hello");
            MyDelegate del_3 = () =>
            {
                Console.WriteLine("Del_3");
            };
            del_3();*/

            NumberEven numeven = delegate (int x)
            {
                return x % 2 == 0;
            };
            Console.WriteLine(numeven(1));
            Console.WriteLine(numeven(2));

            SquareNum squarnum = delegate (int x)
            {
                return x * x;
            };
            Console.WriteLine(squarnum(4));

            Cube cube = x =>
            {
                return x * x * x;
            };
            Console.WriteLine(cube(3));

            ProgramerDay progrday = (day, month) => day == 13 && month == 9;
            (int day, int month)[] day = { (12, 9) };
            foreach(var date in day)
            {
                bool res = progrday(date.day, date.month);
            }

            Max max = arr =>
            {
                return arr.Max();
            };
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(max(arr));
            Max min = arr =>
            {
                return arr.Min();
            };
            Console.WriteLine(min(arr));
            Seach seach = num =>
            {
                int newsize = 0;
                int i = 0;
                foreach (var x in arr) {
                    if (x % 2 != 0)
                    {
                        Console.Write(x + " ");
                    }
                }
            };
            seach(arr);
        }
    }
    /*public class ClassB {
        public void Show()
        {
            Console.WriteLine("Hello");
        }
    }*/
}
