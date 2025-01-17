namespace EventManagementSystem
{
    public class Workshop : Events
    {
        public string Instructor { get; set; }
        public int Duration { get; set; } // Duration in hours

        public Workshop(string name, DateTime date, string location, string instructor, int duration)
            : base(name, date, location)
        {
            Instructor = instructor;
            Duration = duration;
        }

        /*public override void DisplayEventInfo()
        {
            base.DisplayEventInfo();
            Console.WriteLine($"Instructor: {Instructor}, Duration: {Duration} hours");
        }*/
    }
}