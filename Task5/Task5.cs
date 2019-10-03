using System;

namespace Student
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Random random = new Random();

            student.unfinishedTasks = random.Next(0, 6);
            student.iq = random.Next(0, 140);

            int state = random.Next(0, 100);
            student.state = state > 50 ? "Sober" : "Drunk";

            if (student.state == "Drunk" && student.iq < 70 
                || student.state == "Drunk" && student.unfinishedTasks > 3
                || student.iq < 70 && student.unfinishedTasks > 3)
            {
                student.getInfo();
                student.getExpelled();
            }
            else
            {
                state = random.Next(0, 100);
                student.state = state > 50 ? "Sober" : "Drunk";
                if (student.state == "Sober")
                {
                    student.iq += 10;
                    student.getInfo();
                }
            }

            
        }
    }
    class Student
    {
        public int unfinishedTasks;
        public int iq;
        public string state;
        public string name = "Valdemar";
        public string faculty = "Biology";
        public void getInfo()
        {
            Console.WriteLine($"Student name:{name}\nFaculty:{faculty}\nUnfinished tasks:{unfinishedTasks}\nState:{state}\nIq:{iq}");
        }
        public void getExpelled()
        {
            Console.WriteLine("Sudent expelled!");
        }
    }
}
