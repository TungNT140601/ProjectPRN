using System;
namespace Processing_Command_Line_Arguments
{
    class Program
    {
        public static void Main(string[] args)
        {
            string msg = "****Welcome to C#.Net Programming****";
            Console.WriteLine("{0}", msg);
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine($"Arg: {args[i]}");
            }
            Console.ReadLine();
        }
        //chay bang Terminal
    }
}