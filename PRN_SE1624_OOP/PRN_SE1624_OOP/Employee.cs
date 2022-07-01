namespace Prn.Se1624;
public class Employee
{
    /*Define fields (data)*/
    private int _id;
    private string _name;
    private DateOnly _dob;

    /*Define Properties*/
    public double Salary { get; set; }
    public string Level { get; set; }
    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public DateOnly Dob { get => _dob; set => _dob = value; }

    //Constructors

    public Employee()
    {

    }

    public Employee(double salary, string level, int id, string name, DateOnly dob)
    {
        Salary = salary;
        Level = level;
        Id = id;
        Name = name;
        Dob = dob;
    }

    public override string? ToString()
    {
        return GetString();
    }

    private string GetString()
    {
        return $"Id = {this.Id}, Name = {this.Name}, DoB = {this.Dob}," +
            $"Level = {this.Level}, Salary = {this.Salary}";
    }
}
