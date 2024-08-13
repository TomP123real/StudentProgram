internal class Student
    {
        public string studentName;
        public int studentID;
        public int age;
        public Student(string studentName, int studentID, int age)
        {
            this.studentName = studentName;
            this.studentID = studentID;
            this.age = age;
        }
        public string GetstudentName()
        {
            return studentName;
        }
        public void SetstudentName(string studentName)
        {
            this.studentName = studentName;
        }
        public int GetstudentID()
        {
            return studentID;
        }
        public void SetstudentID(int studentID)
        {
            this.studentID = studentID;
        }
        public int Getage()
        {
            return studentID;
        }
        public void Setage(int age)
        {
            this.age = age;
        }
        public interface Iperson
        {
            void DisplayInformation();
        }
        public virtual void DisplayInformation()
        {
            Console.WriteLine($"The details are: {this.studentName}, {this.studentID}, {this.age}");
        }
        public (string studentName, int studentID, double age) GetStudentInfo()
        {
            return (studentName, studentID, age);
        }
    }
internal class CollegeStudent : Student
    {
        private string subject;
        private int average;

        public CollegeStudent(string studentName, int studentID, int age, string subject, int average) : base(studentName, studentID, age)
        {
            this.subject = subject;
            this.average = average;
        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine($"the specific information: {this.subject}, {this.average}");

        }
    }
internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new CollegeStudent("tom", 58904, 17, "programmer", 100);
            student.SetstudentName("daniel");
            student.SetstudentID(54726);
            student.Setage(25);
            student.DisplayInformation();
        }
    }