using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using FochsoApiTester.Models;
using FochsoApiTester.Pages.Students;
using FochsoApiTester.Service.Interface;

namespace FochsoApiTester.Service.Implementations
{
    public class StudentsService : IStudentsService
    {
        private readonly HttpClient _httpClient;
        public StudentsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<StudentsModel>> GetStudentsAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7717/api/Students");
            response.EnsureSuccessStatusCode();
            var responseStream = await response.Content.ReadAsStreamAsync();
            // var responseContent = await  response.Content.ReadAsStringAsync();
            Console.WriteLine($" log : {responseStream}");
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var deserialize = await JsonSerializer.DeserializeAsync<IEnumerable<StudentsModel>>(responseStream,options);
            var studentsList = new List<StudentsModel>();
            foreach (var item in deserialize)
            {
                var std = new StudentsModel
                {
                    Id = item.Id,
                    Name = item.Name,
                    Class = item.Class,
                    ClassId = item.ClassId,
                    CreatedBy = item.CreatedBy,
                    DateCreated = item.DateCreated,
                    LastModified = item.LastModified,
                    ModifiedBy = item.ModifiedBy
                };
                studentsList.Add(std);
            }
            return studentsList;
        }
    }
}