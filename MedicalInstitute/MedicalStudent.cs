using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalInstitute
{
    public class MedicalStudent
    {
        public string Name { get; set; }
        public string Specialization { get; set; }

        public MedicalStudent(string name, string specialization)
        {
            Name = name;
            Specialization = specialization;
        }

        public override string ToString()
        {
            return Name + " " + Specialization;
        }
    }
}
