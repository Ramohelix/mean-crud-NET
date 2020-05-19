using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mean_crud.Models;
using MongoDB.Driver;

namespace mean_crud.Controllers
{   
    [Produces("application/json")]
    [Route("api/Employees")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {

        private Context context;

        public EmployeesController()
        {
            context = new Context();
        }
        // GET: api/Employees
        [HttpGet]
        public IEnumerable<Employees> Get()
        {
            var employees = context.Employees.Find(_ => true).ToList();
            return employees;
        }

        // GET: api/Employees/5
        [HttpGet("{name}", Name = "Get")]
        public IEnumerable<Employees> Get(string name)
        {
            var employees = context.Employees.Find(x => x.Name == name).ToList();
            return employees;
        }

        // POST: api/Employees
        [HttpPost]
        public void Post([FromBody] Employees employees)
        {
            context.Employees.InsertOne(employees);
        }

        // PUT: api/Employees/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
