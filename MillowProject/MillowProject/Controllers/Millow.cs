using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MillowProject.Model;

namespace MillowProject.Controllers
{
    [Route("api/[action]")]
    [ApiController]
    public class Millow : ControllerBase
    {
        public DataContent dbdata;
        public Millow(DataContent data)
        {
            dbdata = data;
        }

        [HttpGet]
        public List<Employee> GetEmployee()
        {
            return dbdata.employees.ToList();
        }
        public List<Company> GetCompany(String name)
        {
            var result= dbdata.company.Where(p => p.employeeName == name).ToList();
            return result;
        }

        [HttpPost]

        public IActionResult createEmployee(Employee data)
        {
            dbdata.employees.Add(data);
            return Ok("200");
        }
        public IActionResult createCompany(Company data)
        {
            dbdata.company.Add(data);
            return Ok("200");
        }
    }

}
