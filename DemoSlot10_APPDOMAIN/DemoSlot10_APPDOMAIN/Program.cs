using System;
using System.Reflection;
namespace DemoSlot10
{
    class Program
    {
        static void Main(string[] args)
        {

            AppDomain defaultAd = AppDomain.CurrentDomain;

            Assembly[] loadAssembly = defaultAd.GetAssemblies();

            Console.WriteLine("The assemblies loaded in {0}", defaultAd.FriendlyName);
            foreach (Assembly a in loadAssembly)
            {
                Console.WriteLine($"--Name, Version: {a.GetName().Name}:{a.GetName().Version}");

            }
            Console.ReadLine();
        }
    }
}