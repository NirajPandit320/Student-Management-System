public class OOP
{
    public static void Run()
    {
        Console.WriteLine("===== OOP LESSON =====");

        Employee emp1 = new Employee();
        emp1.id = 101;
        emp1.name = "John Doe";
        emp1.salary = 50000.0;
        emp1.Display();
    }
}