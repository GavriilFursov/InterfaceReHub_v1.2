using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOblojca
{
    public class Patient
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public double ThighLength { get; set; }
        public double CalfLength { get; set; }
        public double FootLength { get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} {MiddleName}";
        }
    }
}
