public class EventManager
{
    private List<Event> _events = new List<Event>();

    public void AddEvent(Event eventToAdd)
    {
        _events.Add(eventToAdd);
    }

    public void ListEvents()
    {
        foreach (var evt in _events)
        {
            Console.WriteLine($"Event: {evt.Name}, Date: {evt.Date}");
        }
    }

    public void RegisterStudentForEvent(Student student, string eventName)
    {
        Event? foundEvent = _events.FirstOrDefault(e => e.Name == eventName);

        if (foundEvent != null)
        {
            foundEvent.Register(student);
        }
        else
        {
            Console.WriteLine($"Event with name '{eventName}' not found.");
        }
    }

    public void SendEventNotifications()
    {
        foreach (var evt in _events)
        {
            evt.SendNotifications();
        }
    }
}