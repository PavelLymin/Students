using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;

namespace SoftwareEngineering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SEStudent student1 = new SEStudent("Виктория", "Python");
            SEStudent student2 = new SEStudent("Андрей", "Java");
            SEStudent student3 = new SEStudent("Артем", "C++");

            Department<SEStudent> department = new Department<SEStudent>() 
            {
                Title = "Информационные системы и технологии",
                Supervisor = "Андрей Викторович"
            };

            department.EnrolStudent(student1); /*Добавление студентов в массив*/
            department.EnrolStudent(student2); /*Добавление студентов в массив*/
            department.EnrolStudent(student3); /*Добавление студентов в массив*/

            department.ExpelStudent(student1); /*Удаление из массива студента*/

            SEStudent[] sestudent = department.GetStudentsList();
            foreach(SEStudent student in sestudent) /*Вывод студентов*/
            {
                if (student != null) 
                {
                    Console.WriteLine(student.ToString());
                }
            }

        }
    }
}
