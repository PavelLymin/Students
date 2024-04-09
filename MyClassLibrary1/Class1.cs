using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MyClassLibrary1
{
    public class Department<T>
    {
        public string Title { get; set; }
        public string Supervisor { get; set; }
        
        private T[] Students;

        public Department()
        {
            Students = new T[0];
        }

        public void EnrolStudent(T student)
        {
            if (!Students.Contains(student)) 
            {
                Array.Resize(ref Students, Students.Length + 1);
                for (int i = 0; i < Students.Length; i++)
                {
                    if (Students[i] == null)
                    {
                        Students[i] = student;
                    }
                }
            }
        }

        public void ExpelStudent(T student)
        {
            int index = Array.IndexOf(Students, student);

            if (Students.Contains(student))
            {
                if (index != -1)
                {
                    for (int i = index; i < Students.Length - 1; i++)
                    {
                        Students[i] = Students[i + 1];
                    }
                    Students[Students.Length - 1] = default;
                }
            }
        }

        public T[] GetStudentsList()
        {
            T[] NewArray = new T[Students.Length];
            for (int i = 0; i < Students.Length; i++)
            {
                NewArray[i] = Students[i];
            }
            return NewArray;
        }
    }
}
