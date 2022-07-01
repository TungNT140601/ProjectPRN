using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest_Slot02_03
{
    class DemoSlot03
    {
        static void Main(string[] args)
        {
            int flag = 0;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Cong");
                Console.WriteLine("2.Tru");
                Console.WriteLine("3.Nhan");
                Console.WriteLine("4.Chia");
                Console.WriteLine("5.Thoat");

                int choice = int.Parse(Console.ReadLine());
                int a, b;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("1st num: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("2nd num: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + add(a, b));
                        break;
                    case 2:
                        Console.WriteLine("1st num: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("2nd num: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + sub(a, b));
                        break;
                    case 3:
                        Console.WriteLine("1st num: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("2nd num: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + multi(a, b));
                        break;
                    case 4:
                        Console.WriteLine("1st num: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("2nd num: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Result: " + division(a, b));
                        break;
                    case 5:
                        Console.WriteLine("Goodbye");
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("Input again!");
                        break;
                }
            } while (flag != 1);
        }

        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double sub(double a, double b)
        {
            return a - b;
        }
        public static double multi(double a, double b)
        {
            return a * b;
        }
        public static double division(double a, double b)
        {
            return a / b;
        }

    }
}
