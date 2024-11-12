namespace TASK
{
    internal class Program
    {
        Scoreprocess scoreprocess = new Scoreprocess();
        static void Main(string[] args)
        
        {
           
            Scoreprocess scoreprocess = new Scoreprocess();

            //scoreprocess.Filterstudents(Passed);
            //scoreprocess.Filterstudents(failed);

            //Console.WriteLine("--------------------------");

            //scoreprocess.Filterstudents(delegate (Student student) { return student.Score >= 50; });
            //scoreprocess.Filterstudents(delegate (Student student) { return student.Score < 50; });

            //Console.WriteLine("---------------------------");

            //scoreprocess.Filterstudents((Student student) => student.Score >= 50);
            //scoreprocess.Filterstudents((Student student) => student.Score < 50);

            //Console.WriteLine("---------------------------");

            Console.WriteLine("passed");
            scoreprocess.Filterstudents(student  => student.Score >= 50);
            Console.WriteLine("---------------");
            Console.WriteLine("failed");
            scoreprocess.Filterstudents(student  => student.Score < 50);
            Console.WriteLine("---------------");
            scoreprocess.students.PrintStudentList();
            scoreprocess.students.topscorer();
            scoreprocess.students.AVGscorer();
        }

        
        static bool Passed(Student student) => student.Score >= 50;
        static bool failed(Student student) => student.Score < 50;

        
    }
}
