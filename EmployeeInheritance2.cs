public class EmployeeEnheritance2
{
    public static void Run()
    {
        EmployeeInheritance1 emp1 = new EmployeeInheritance1();
        emp1.Id = 1000021775;
        emp1.Name = "John Doe";
        emp1.Salary = 50000;
        emp1.Department = "IT";
        emp1.DisplayBasicEmployeeInfo();
    }
}