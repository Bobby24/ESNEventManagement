public abstract class Event
{
    public string Name { get; set; } 
    public DateTime Date { get; set; } 
    public string Location { get; set; }
    public string Description { get; set; }
    public int Capacity { get; set; } 
    public List<Student> RegisteredStudents { get; private set; } = new List<Student>(); // Track registered students

    public Event(string name, DateTime date, string location, string description, int capacity) 
    {
        Name = name;
        Date = date;
        Location = location;
        Description = description;
        Capacity = capacity;
    }

    // Abstract method for registration 
    public abstract void Register(Student student); 

    // Method to send email notifications (simplified)
    public virtual void SendNotifications()
    {
        if (RegisteredStudents.Count > 0) 
        {
            Console.WriteLine($"Sending email notifications to {RegisteredStudents.Count} participants...");
            foreach (var student in RegisteredStudents)
            {
                // Simulate sending email (replace with actual email logic)
                Console.WriteLine($"Notification sent to: {student.Name}"); 
            }
        } 
        else 
        {
            Console.WriteLine("No participants registered for this event.");
        }
    }

    // Method to check if event has reached capacity
    public bool IsFull() 
    {
        return RegisteredStudents.Count >= Capacity;
    }
}