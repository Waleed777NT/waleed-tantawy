using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{

    static class ListExtensions
    {

       public static void PrintStudentList(this List<Student> students)
        {
            Console.WriteLine("student list............");
           foreach (var student in students)
            {
                Console.WriteLine($"Name : {student.Name} Degreee : {student.Score}");
            }
        }

        public static void topscorer(this List<Student> students)
        {
            decimal maxscore = 0;
            string namew ="";
           foreach (var student in students)
            {
                if (maxscore < student.Score)
                {
                    maxscore = student.Score;
                    namew = student.Name;
                }
            }
            Console.WriteLine($"Top scorer: {namew} with a score equals {maxscore}");

            
        }
        public static void AVGscorer(this List<Student> students)
        {
            decimal sum = 0;
            int count = 0;
            foreach (var student in students)
            {
                sum += student.Score;
                count++;
            }
            decimal result = sum / count;
          
            Console.WriteLine($"average for students is {Math.Round(result,2)}");
            


        }

    }
}
