namespace Threading;
public class Program
{
    public static void Main()
    {
        //ThreadingDemo t = new ThreadingDemo();
        //t.printNum();


        /*
        printNumber();
        printNumber();
        printNumber();
        */
        ThreadExecute();
        Console.ReadLine();
    }
    public static void ThreadExecute()
    {
        /*Tạo ra 3 thread, mỗi thread thực thi 1 việc*/

        Thread t1 = new Thread(() => printNumber("Threading 1"));
        t1.Start();
        Thread t2 = new Thread(() => printNumber("Threading 2"));
        t2.Start();
        Thread t3 = new Thread(() => printNumber("Threading 3"));
        t3.Start();

    }
    public static void printNumber(string t)
    {
        Console.WriteLine($"{t} is executing");
        /*Thuc thi in ra tu 1 den 5, moi lan cach nhau 1s*/
        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(t + "-" + i);
        }
    }
}