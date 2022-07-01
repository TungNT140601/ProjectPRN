using System.Threading;
namespace Prn.Se1624.Threading;

public class ThreadingDemo
{
    public void PrintNumber()
    {
        /*Thuc thi in ra tu 1 den 5, moi lan in cach nhau 1s*/
        for(int i = 1; i <= 5; i++)
        {
            Thread.Sleep(100);
            Console.WriteLine(i);
        }
    }
}
