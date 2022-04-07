using System;

namespace task4var23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student("st1", 0.8, 3);
            Student s2 = new improvedStudent("st2", 0.8, 3, true);
            Student s3 = new improvedStudent("st3", 0.8, 3, false);
            
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
        }
    }
}