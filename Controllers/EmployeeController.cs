using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ErHaSolution.Data;
using ErHaSolution.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ErHaSolution.Controllers
{
    [Route("Employee")]
    public class EmployeeController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Employee>>> SelecionarTodos([FromServices] DataContext context)
        {
            try
            {
                var employee = await context
                    .Employee
                    .Include(x => x.EmployeeCategory)
                    .AsNoTracking()
                    .ToListAsync();
                if (employee == null)
                {
                    NotFound();
                }
                return employee;
            }

            catch
            {
                return BadRequest(new { message = "Erro ao consultar funcionário" });
            }
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Employee>> SelecionarPorId([FromServices] DataContext context, int id)
        {
            try
            {
                var employee = await context
                    .Employee
                    .Include(x => x.EmployeeCategory)
                    .AsNoTracking()
                    .FirstOrDefaultAsync(p => p.Id.Equals(id));
                if (employee == null)
                {
                    NotFound();
                }

                return employee;
            }
            catch
            {
                return BadRequest(new { message = "Erro ao consultar funcionário" });
            }
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<List<Employee>>> InserirFuncionario(
                    [FromBody] Employee employee,
                    [FromServices] DataContext context)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                context.Employee.Add(employee);
                await context.SaveChangesAsync();
                return Ok(employee);
            }
            catch (Exception err)
            {
                return BadRequest(err);
            }
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Employee>>> AtualizarFuncionario(int id,
                        [FromBody] Employee employee,
                        [FromServices] DataContext context)
        {

            if (employee.Id != id)
            {
                return NotFound(new { message = "funcionário não encontrado" });
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                context.Entry<Employee>(employee).State = EntityState.Modified;
                await context.SaveChangesAsync();
                return Ok(employee);

            }
            catch
            {
                return BadRequest(new { message = "Erro ao atualizar funcionário" });
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<List<Employee>>> DeletarFuncionario(int id)
        {
            try
            {
                return Ok();
            }
            catch
            {
                return BadRequest(new { message = "Erro ao deletar funcionário" });
            }

        }

    }
}
