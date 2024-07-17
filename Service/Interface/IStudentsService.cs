using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FochsoApiTester.Models;

namespace FochsoApiTester.Service.Interface
{
    public interface IStudentsService
    {
        Task<IEnumerable<StudentsModel>> GetStudentsAsync();
    }
}