public class Student
{
    public int RollNumber{ get; set; }
    public string Name{ get; set; }="";
    public string Course{ get; set; }="";
    public double Cgpa{ get; set; }


    //for while at once constructor
    public Student(int rollNumber, string name, string course, double cgpa)
    {
        RollNumber = rollNumber;
        Name = name;
        Course = course;
        Cgpa = cgpa;
    }

    
    public void Display()
    {
        Console.WriteLine("===== STUDENT DETAILS =====");
        Console.WriteLine($"Roll Number: {RollNumber}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Course: {Course}");
        Console.WriteLine($"CGPA: {Cgpa}");
    }
}