namespace Exam
{
    public abstract class Student
    {
        protected const int CountOfLessons = 20;

        protected string Name { get; private set; }
        protected string Surname { get; private set; }
        protected string MiddleName { get; private set; }
        protected int AttendedClasses { get; private set; }

        public Student(string name, string surname, string middleName, int attendedClasses)
        {
            Name = name;
            Surname = surname;
            MiddleName = middleName;
            AttendedClasses = attendedClasses;
        }

        public Student()
        {
            
        }
        
        public abstract bool PassExam();
    }
}