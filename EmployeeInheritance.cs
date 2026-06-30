public class EmployeeInheritance
{
    public int Id{get;set;}
    public string Name{get;set;}="";
    public double Salary{get;set;}

    public void DisplayFullEmployeeInfo()
    {
        Console.WriteLine("===== EMPLOYEE DETAILS =====");
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {Salary}");
    }
}