using System.Diagnostics;
using System.Linq;
namespace ProcessDemo;
public static class ProgramProcess
{
    public static void Main()
    {
        int no = 1;
        string info;

        var runningProc = from n in Process.GetProcesses(".")
                          orderby n.Id
                          select n;
        foreach(var p in runningProc)
        {
            info = $"#{no++}. PID: {p.Id} \t Name:{p.ProcessName}";
            Console.WriteLine(info);
        }
        Console.ReadLine();
    }
}