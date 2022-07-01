namespace Prn.Se1624;
using static System.Console;
using System.Collections;
public class Program
{
    public static void Main()
    {
        /*1. create an object (instance) */
        //Employee e = new Employee();
        //e.Id = 1;
        //e.Name = "Tung";
        //e.Level = "Senior";
        //e.Salary = 1500.55;

        //Employee e = new Employee(1500, "Junior", 1, "Dong", new DateOnly());
        //Employee e1 = new Employee(1500.55, "Senior", "Tung", new DateOnly());

        //ArrayList lstEmp = new ArrayList();
        //WriteLine(e);
        Circle c = new Circle(100d, "Red");
        Shape s = new Circle(1000d, "Yellow");
        WriteLine(s.GetArea());

        WriteLine(c);
        ReadLine();
    }
}