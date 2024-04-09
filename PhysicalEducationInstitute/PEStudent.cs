using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhysicalEducationInstitute
{
    public class PEStudent
    {
        public string FIO { get; set; }
        public string SportDiscipline { get; set; }

        public PEStudent(string fIO, string sportDiscipline)
        {
            FIO = fIO;
            SportDiscipline = sportDiscipline;
        }

        public override string ToString()
        {
            return FIO + " " + SportDiscipline;
        }
    }
}
