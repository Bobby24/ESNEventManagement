public class Trip : Event 
{
    public string Destination { get; set; } 

    public Trip(string name, DateTime date, string location, string description, int capacity, string destination) 
        : base(name, date, location, description, capacity) 
    {
        Destination = destination; 
    }

    public override void Register(Student student) 
    {
        if (!IsFull()) 
        {
            RegisteredStudents.Add(student); 
            Console.WriteLine($"{student.Name} registered for the {this.Name} trip to {this.Destination}."); 
        } 
        else 
        {
            Console.WriteLine($"Trip is full. {student.Name} cannot register."); 
        }
    }
}