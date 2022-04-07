namespace task4var23
{
    public class improvedStudent : Student
    {
        private bool leng;
        
        
        public improvedStudent(string name, double gpa, int course, bool leng) 
            : base(name, gpa, course)
        {
            this.leng = leng;
        }

        
        private double Q()
        {
            if (leng) return base.Q() * 2;
            else return base.Q() * 0.9;
        }
        
        public override string ToString()
        {
            string result;
            result = $"Студент: {surname}\nСредний балл: {gpa}, Курс: {course}\n";
            if (leng) result += "Студент изучает на иностранном языке\n";
            else result += "Студент не изучает на иностранном языке\n";
            result += $"Качество: {Q()}\n";
            return result;
        }
    }
}