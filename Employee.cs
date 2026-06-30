public class Employee
{
    public int id;
    public string name;
    public double salary;

    public void Display()
    {
        Console.WriteLine("===== EMPLOYEE DETAILS =====");
        Console.WriteLine($"ID: {id}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Salary: {salary}");
    }
}