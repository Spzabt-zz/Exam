using System;

namespace Exam
{
    public class GeniusStudent : Student
    {
        private Random _random;
        
        public GeniusStudent(string name, string surname, string middleName, int attendedClasses) : base(name, surname, middleName, attendedClasses)
        {
            _random = new Random();
        }

        public GeniusStudent()
        {
            
        }

        public override bool PassExam()
        {
            return AttendedClasses >= 1;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Middle name: {MiddleName}, Attended classes: {AttendedClasses}";
        }
    }
}