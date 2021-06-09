using System;

namespace Exam
{
    public class CleverS : Student
    {
        private Random _random;
        
        public CleverS(string name, string surname, string middleName, int attendedClasses) : base(name, surname, middleName, attendedClasses)
        {
            _random = new Random();
        }

        public CleverS()
        {
            
        }

        public override bool PassExam()
        {
            if (AttendedClasses == CountOfLessons)
                return true;
            if (AttendedClasses > CountOfLessons / 2)
            {
                if (_random.NextDouble() < 0.7)
                    return false;
                else
                    return true;
            }

            return false;
        }
        
        public override string ToString()
        {
            return $"Name: {Name}, Surname: {Surname}, Middle name: {MiddleName}, Attended classes: {AttendedClasses}";
        }
    }
}