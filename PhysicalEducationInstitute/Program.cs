using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;

namespace PhysicalEducationInstitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PEStudent pEStudent1 = new PEStudent("Лев", "Конькобежный спорт");
            PEStudent pEStudent2 = new PEStudent("Дмитрий", "Волейбол");
            PEStudent pEStudent3 = new PEStudent("Анастасия", "Легкая атлетика");

            Department<PEStudent> department = new Department<PEStudent>() 
            {
                Title = "Педагогическая деятельность",
                Supervisor = "Александр Александрович"
            };

            department.EnrolStudent(pEStudent1); /*Добавление студентов в массив*/
            department.EnrolStudent(pEStudent2); /*Добавление студентов в массив*/
            department.EnrolStudent(pEStudent3); /*Добавление студентов в массив*/

            department.ExpelStudent(pEStudent3); /*Удаление из массива студента*/

            PEStudent[] pEStudents = department.GetStudentsList();
            
            foreach (PEStudent student in pEStudents) /*Вывод студентов*/
            {
                if (student != null)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
