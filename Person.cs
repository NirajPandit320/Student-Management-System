public class Person
{

    public int age { get; set; }
    public string name { get; set; } = "";

    public void DisplayPerson()
    {
        Console.WriteLine("===== PERSON DETAILS =====");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Name: {name}");
    }
}

