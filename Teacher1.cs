public class Teacher1:Person
{
    public int TeacherId{ get; set; }
    public string Subject{ get; set; } = "";

    public void DisplayTeacher()
    {
        Console.WriteLine("===== TEACHER DETAILS =====");
        DisplayPerson();
        Console.WriteLine($"Teacher Id: {TeacherId}");
        Console.WriteLine($"Subject: {Subject}");
    }
}