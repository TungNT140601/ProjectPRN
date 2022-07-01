
namespace Prn.Se1624.Threading;

public class Program
{
    public static void Main()
    {
        /*
        PrintNumber();
        PrintNumber();
        PrintNumber();
        */
        //ThreadExecute();
        MultiThreadingDemo();
        Console.ReadLine();
    }

    public static void ThreadExecute()
    {
        /*Tao ra 3 thread, moi thread thuc thi 1 viec*/
        Thread t1 = new Thread(() => PrintNumber("Threading 1"));
        t1.Start();
        Thread t2 = new Thread(() => PrintNumber("Threading 2"));
        t2.Start();
        Thread t3 = new Thread(() => PrintNumber("Threading 3"));
        t3.Start();
    }


    public static void PrintNumber(string nameThread)
    {
        Console.WriteLine($"{nameThread} is execute...");
        /*Thuc thi in ra tu 1 den 5, moi lan in cach nhau 1s*/
        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(nameThread + " - "+ i);
        }
    }
    public static void MultiThreadingDemo()
    {
        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(() => {
                PrintNumber("Thread " + i);
            });
            t.Start();
        }

        Console.ReadLine();
    }
}