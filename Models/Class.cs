using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FochsoApiTester.Models
{
    public class Class
    {
         public string Name { get; set; }
        public string Description { get; set; }
		//public int StudentId { get; set; }

		public ICollection<StudentsModel> Students { get; set; } = new HashSet<StudentsModel>();
    }
}