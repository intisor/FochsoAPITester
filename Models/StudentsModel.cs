using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FochsoApiTester.Models
{
    public class StudentsModel : BaseModel
    {
         public string Name { get; set; }
        public string Class { get; set;}
        public int ClassId { get; set;}
        public Class? ClassClass { get; set;}
        public ICollection<Result>? Results { get; set; } = new HashSet<Result>();
    }
}