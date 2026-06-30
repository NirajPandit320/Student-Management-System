public class Student1:Person
{
    public int rollno{ get; set; }
    public string department{ get; set; } = "";

    public void DisplayStudent()
    {
        Console.WriteLine("===== STUDENT DETAILS =====");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Roll No: {rollno}");
        Console.WriteLine($"Department: {department}");
    }

}