public class Abstraction
{
    public static void Run()
    {
        EmployeeAbstract[] employees = {
        new Developer1{name="Niraj"},
        new Manager1{name="Ramesh"},
        };
        foreach (var employee in employees)
        {
            employee.DisplayEmployee();
        }
    }
}