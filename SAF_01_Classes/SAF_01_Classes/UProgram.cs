using System;
using System.Collections.Generic;
using System.Text;

namespace SAF_01_Classes
{
    public class UProgram
    {
        public string UPName { get; set; }
        public List<Degree> Degree { get; set; }

        public UProgram(string upname)
        {
            this.UPName = upname;
        }
    }
}
