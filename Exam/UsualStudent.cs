using System;
using System.Windows.Forms;

namespace Exam
{
    public class UsualStudent : Student
    {
        private Random _random;

        public UsualStudent(string name, string surname, string middleName, int attendedClasses) : base(name, surname,
            middleName, attendedClasses)
        {
            _random = new Random();
        }

        public UsualStudent()
        {
        }

        public override bool PassExam()
        {
            float res = 0;
            if (AttendedClasses == CountOfLessons)
                return true;
            if (AttendedClasses > CountOfLessons / 2)
            {
                if (_random.NextDouble() < 0.5)
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