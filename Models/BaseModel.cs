using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FochsoApiTester.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set;}
        public DateTime LastModified { get; set;}
        public string? ModifiedBy { get; set;}
    }
}