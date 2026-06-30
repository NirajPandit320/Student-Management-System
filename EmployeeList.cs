public class EmployeeList
{
    public static void Run()
    {
        List<string> employee=new List<string>();
        employee.Add("John");
        employee.Add("Smith");
        employee.Add("Niraj");
        employee.Add("Ramesh");

        Console.WriteLine("===== EMPLOYEE LIST =====");
        foreach(string emp in employee)
        {
            Console.WriteLine(emp);
        }
    }
}