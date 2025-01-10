class Program
{
    static void Main(string[] args)
    {
        EventManager eventManager = new EventManager();

        // Create sample events
        Workshop workshop = new Workshop("Introduction to C#", DateTime.Now.AddDays(7), "University Hall", "Learn C# basics", 20, "C# Fundamentals");
        Trip trip = new Trip("City Tour", DateTime.Now.AddDays(10), "Old Town", "Explore the city", 15, "City Center");

        eventManager.AddEvent(workshop);
        eventManager.AddEvent(trip);

        // Display events
        Console.WriteLine("Available Events:");
        eventManager.ListEvents();

        // Simulate student registration
        Student student1 = new Student("John Doe", "12345", "john.doe@example.com");
        eventManager.RegisterStudentForEvent(student1, "Introduction to C#"); 

        // Send notifications
        eventManager.SendEventNotifications();

        Console.ReadLine(); 
    }
}