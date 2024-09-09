namespace College
{
    internal class Program
    {
        void ManageStudent() {
        Student student = new Student();
            student.display();
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.ManageStudent();
        }
    }
}
