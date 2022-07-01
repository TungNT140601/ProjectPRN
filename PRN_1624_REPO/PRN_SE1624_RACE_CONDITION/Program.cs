using System;
using System.Threading;
namespace RaceConditions;
public class Printer
{
    public void PrintNumber()
    {
        //Display thread-info
        Console.WriteLine($"{Thread.CurrentThread.Name} is executing PrintNumber()");
        //print out numbers
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Second Thread: {i}");
            Thread.Sleep(0);
        }
        Console.ReadLine();
    }
}
public class Program
{
    public static void Main()
    {
            Printer p = new Printer();
            Thread[] tr = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                tr[i] = new Thread(new ThreadStart(p.PrintNumber));
                tr[i].Name = String.Format("Working Thread: {0}", i);
            }
            //Start each thread  
            foreach (Thread x in tr)
            {
                x.Start();
            }
            Console.ReadKey();
        
    }
}

