public class Workshop : Event 
{
    public string Topic { get; set; } 

    public Workshop(string name, DateTime date, string location, string description, int capacity, string topic) 
        : base(name, date, location, description, capacity) 
    {
        Topic = topic; 
    }

    public override void Register(Student student) 
    {
        if (!IsFull()) 
        {
            RegisteredStudents.Add(student); 
            Console.WriteLine($"{student.Name} registered for the {this.Name} workshop."); 
        } 
        else 
        {
            Console.WriteLine($"Workshop is full. {student.Name} cannot register."); 
        }
    }
}