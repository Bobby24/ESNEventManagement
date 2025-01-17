using System;
using System.Collections.Generic;

namespace EventManagementSystem
{
    public class Students
    {
        // static counter variable to generate unique Student IDs
        private static int _counter = 0;

        // declare our properties
        private int _studentID;
        private string _firstName;
        private string _lastName;
        // date of birth as a DateTime
        private DateTime _dateOfBirth;
        private string _nationality;
        private string _cityofstudy;

        // define our getters and setters including basic validation
        public int StudentID
        {
            get => _studentID;
            // ensure ID is positive and cannot be changed
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Student ID must be a positive integer.");
                    _studentID = value;
                }
            }
        }

        public string FirstName
        {
            get => _firstName;
            // Validate that the name is not null, empty of whitespace
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");
                }
                _firstName = value;
            }
        }

        public string LastName
        {
            get => _lastName;
            // Validate that the name is not null, empty of whitespace
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty.");
                }
                _lastName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException("Date of birth cannot be in the future.");
                }
                _dateOfBirth = value;
            }
        }

        public string Nationality
        {
            get => _nationality;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Nationality cannot be null or empty.");
                }
                _nationality = value;
            }
        }

        public string Cityofstudy
        {
            get => _cityofstudy;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("City of study cannot be null or empty.");
                }
                _cityofstudy = value;
            }
        }

        // Constructor for scenatios where we import data from a CSV file
        public Students(int studentID, string firstName, string lastName, DateTime dateOfBirth, string nationality, string cityofstudy)
        {
            StudentID = studentID;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            Cityofstudy = cityofstudy;
        }

        // Constructor for scenarios where we create a new Student automatically with incrementing counter for student ID
        public Students(string firstName, string lastName, DateTime dateOfBirth, string nationality, string cityofstudy)
        {
            _counter++;
            StudentID = _counter;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Nationality = nationality;
            Cityofstudy = cityofstudy;
        }

        // Format the Students details for user-friendly display
        public override string ToString()
        {
            return $"Student ID: {StudentID}" + $"Name: {FirstName} {LastName}" + $"Date of Birth: {DateOfBirth:dd/MM/yyyy}" + $"Nationality: {Nationality}" + $"City of Study: {Cityofstudy}";
        }
    }
}