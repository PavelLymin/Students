using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareEngineering
{
    public class SEStudent
    {
        public string FIO { get; set; }
        public string ProgrammingLanguage { get; set; }

        public SEStudent(string fIO, string programmingLanguage)
        {
            FIO = fIO;
            ProgrammingLanguage = programmingLanguage;
        }

        public override string ToString()
        {
            return FIO + ". Знает " + ProgrammingLanguage;
        }
    }
}
