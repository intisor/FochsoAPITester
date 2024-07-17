using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FochsoApiTester.Models
{
    public class Result
    {
         public int English { get; set; }
        public int Mathematics { get; set; }
        public int Civic { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public StudentsModel Student { get; set; }

    }
}