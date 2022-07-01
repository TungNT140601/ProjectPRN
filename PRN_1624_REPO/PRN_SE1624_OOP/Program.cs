/*Lap trinh tao ra mot List cac Employees ma in ra man hinh*/
namespace Prn.Se1624;
using static System.Console;
using System.Collections;

public class Program
{
    public static void Main()
    {
        /*1. create a object (instance)*/
        /*
        Employee e = new Employee();
        e.Id = 1;
        e.Name = "Bui Huu Dong";
        e.Level = "Senior";
        e.Salary = 1500.55f;
        */
        //Employee e = new Employee(1500f,"Junior",1,"Dong",new DateOnly());
        /*2. Create a list Employees and filter and display to console*/
        /*
        ArrayList lstEmps = new ArrayList();
        lstEmps.Add(e);
        lstEmps.Add(new Employee(5000f, "Senior", 2, "Hai", new DateOnly()));
        lstEmps.Add(new Employee(6000f, "Senior", 3, "Hai", new DateOnly()));
        lstEmps.Add(new Employee(7000f, "Senior", 4, "Hai", new DateOnly()));
        lstEmps.Add(new Employee(8000f, "Senior", 5, "Hai", new DateOnly()));

        Display(lstEmps);
        WriteLine(e);  
        */
        Circle c = new Circle(1525d,"Red");
        Shape s = new Circle(12456d, "Blue");//polymorphis
        //c.Display();
        s.Display();

        WriteLine(s.GetArea());

        WriteLine(c);


        //Object initalize
        IShape s2 = new Rectangle() { Width=124, Height =456};
        WriteLine(s2.GetArea());

        ReadLine();
    }

    public static void Display(ArrayList lstData)
    {
        foreach (Employee e in lstData)
        {
            WriteLine(e);
        }
    }
}
