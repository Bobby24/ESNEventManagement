public class Student
{
    public string Name { get; set; }
    public string StudentID { get; set; }
    public string Email { get; set; } 

    public Student(string name, string studentID, string email)
    {
        Name = name;
        StudentID = studentID;
        Email = email;
    }
}