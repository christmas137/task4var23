namespace task4var23
{
    public class Student
    {
        protected string surname;
        protected double gpa;
        protected int course;


        public Student(string surname, double gpa, int course)
        {
            this.surname = surname;
            this.gpa = gpa;
            this.course = course;
        }


        protected double Q()
        {
            return 0.2 * gpa * course;
        }

        public override string ToString()
        {
            string result;
            result = $"Студент: {surname}\nСредний балл: {gpa}, Курс: {course}\nКачество: {Q()}\n";
            return result;
        }
    }
}