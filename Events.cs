using System;

namespace EventManagementSystem
{
    public class Events
    {
        // static counter variable to generate unique Event IDs
        private static int _counter = 0;

        // declare our properties
        private int _eventID;
        private string _name;
        private string _description;
        private string _location;
        // declare event date as a DateTime
        private DateTime _date;
        // declare event start time as a TimeSpan
        private TimeSpan _startTime;
        // declare event price per participant as a decimal
        private decimal _pricePerParticipant;
        internal static readonly IEnumerable<Events> EventsList;

        // define our getters and setters including basic validation
        public int EventID
        {
            get => _eventID;
            // ensure ID is positive and cannot be changed
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Event ID must be a positive integer.");
                    _eventID = value;
                }
            }
        }

        public string Name
        {
            get => _name;
            // Validate that the name is not null, empty of whitespace
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Event name cannot be null or empty.");
                }
                _name = value;
            }
        }

        public string EventDescription // optional event description
        {
            get => _description;
            set => _description = value;
        }
        
        // Validate that the location is not null, empty of whitespace
        public string Location
        {
            get => _location;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Event location cannot be null or empty.");
                }
                _location = value;
            }
        }

        // Validate that the date is in date format
        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        // Validate that the start time is not null
        public TimeSpan StartTime
        {
            get => _startTime;
            set => _startTime = value;
        }

        // Validate that the price per participant is not negative
        public decimal PricePerParticipant
        {
            get => _pricePerParticipant;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price per participant cannot be negative.");
                }
                _pricePerParticipant = value;
            }
        }

        // Constructor for scenarios like importing data from a database
        public Events(int eventID, string name, string description, string location, DateTime date, TimeSpan startTime, decimal pricePerParticipant)
        {
            EventID = eventID;
            Name = name;
            EventDescription = description;
            Location = location;
            Date = date;
            StartTime = startTime;
            PricePerParticipant = pricePerParticipant;

            // update the counter to ensure unique IDs for future Events
            if (eventID >= _counter)
            {
                _counter = eventID + 1;
            }
        }

        // Constructor for scenarios like creating a new Event with automatically incrementing the counter
        public Events(string name, string description, string location, DateTime date, TimeSpan startTime, decimal pricePerParticipant)
        {
            EventID = ++_counter;
            Name = name;
            EventDescription = description;
            Location = location;
            Date = date;
            StartTime = startTime;
            PricePerParticipant = pricePerParticipant;
        }

        public Events(string name, DateTime date, string location)
        {
            Name = name;
            Date = date;
            Location = location;
        }

        // Format the Event details for user-friendly display
        public override string ToString()
        {
            return $"Event ID: {EventID}\nName: {Name}\nDescription: {EventDescription}\nLocation: {Location}\nDate: {Date.ToShortDateString()}\nStart Time: {StartTime}\nPrice per Participant: {PricePerParticipant:C}";
        }

        internal void DisplayEventInfo()
        {
            throw new NotImplementedException();
        }
    }
}