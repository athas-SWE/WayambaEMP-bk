﻿using Microsoft.AspNetCore.Mvc;
using Weaapp.Models;
using Weaapp.Repository;

namespace Weaapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository emp;

        public EmployeeController(EmployeeRepository employeeRepository)
        {
            this.emp = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> EmployeeList()
        {
            var allEmployees = await emp.GetAllEmployees();
            return Ok(allEmployees);
        }

        [HttpPost]

        public async Task<ActionResult> AddEmployee(Employee vm)
        {
            await emp.SaveEmployee(vm);
            return Ok(vm);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> updateEmployee (int id, [FromBody]Employee vm)
        {
            await emp.updateEmployee(id, vm);
            return Ok(vm);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> deleteEmployee(int id)
        {
            await emp.DeleteEmployee(id);
            return Ok();
        }
    }
}