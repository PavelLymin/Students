using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyClassLibrary1;

namespace MedicalInstitute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MedicalStudent student1 = new MedicalStudent("Алексей","Медик");
            MedicalStudent student2 = new MedicalStudent("Александр", "Медик");
            MedicalStudent student3 = new MedicalStudent("Екатерина", "Медик");

            Department<MedicalStudent> department = new Department<MedicalStudent>()
            {
                Title = "Лечебное дело",
                Supervisor = "Дмитрий Дмитриевич",
            };
            
            department.EnrolStudent(student1); /*Добавление студентов в массив*/
            department.EnrolStudent(student2); /*Добавление студентов в массив*/
            department.EnrolStudent(student3); /*Добавление студентов в массив*/

            department.ExpelStudent(student3); /*Удаление из массива студента*/
            department.ExpelStudent(student3);

            MedicalStudent[] students = department.GetStudentsList();

            foreach (MedicalStudent student in students) 
            {
                if (student != null)
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
