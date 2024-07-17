using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FochsoApiTester.Models;
using FochsoApiTester.Service.Implementations;
using FochsoApiTester.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace FochsoApiTester.Pages.Students
{
    public class Students : PageModel
    {
        private readonly ILogger<Students> _logger;
        private readonly IStudentsService _studentsService;

        public Students(ILogger<Students> logger,IStudentsService studentsService)
        {
            _logger = logger;
            _studentsService = studentsService;
        }
        public IEnumerable<StudentsModel> Student {get;set;}
        public async Task OnGetAsync()
        {
            Student = await  _studentsService.GetStudentsAsync();
        }
    }
}