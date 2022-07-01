using System.Collections;
using static System.Console;
using System.Linq;

string[] names = {"dong","Nguyen Cong Phuong","Lan","Pack Hang Seo","Ma Van Meo","van" };

//1 sap xep theo chieu dai cua ten
//Array.Sort(names);
//2. Dung SortedSet
//SortedSet<string> list = new SortedSet<string>(names);
//3. Linq
dynamic data= names.OrderBy(x => x.Length);


//4. filter cac names ma co lenth >4 (dang 1: Linq)
data = names.Where(n => n.Length > 4);

//4. Dang 2 - LinQ (Query Expression) - Linq to objects

data = from n in names
       where n.Contains("a")
       select n;

//display
foreach (string name in data)
{
    WriteLine(name);
}
