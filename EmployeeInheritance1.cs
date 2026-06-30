public class EmployeeInheritance1: EmployeeInheritance
{
    public string Department{get;set;}="";

    public void DisplayBasicEmployeeInfo()
    {
        DisplayFullEmployeeInfo();
        Console.WriteLine($"Department: {Department}");
    }
}