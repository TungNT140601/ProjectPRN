using System.Threading;
namespace Threading;
public class ThreadingDemo
{
    public void printNum()
    {
        /*Thuc thi in ra tu 1 den 5, moi lan cach nhau 1s*/
        for (int i = 1; i <= 5; i++)
        {
            Thread.Sleep(1000);
            Console.WriteLine(i);
        }
    }
}
