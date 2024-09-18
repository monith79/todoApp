using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq; //Syntax the same SQL
using System.Threading.Tasks;
using System.Collections.Generic;
using todoAPI.Data;

using Microsoft.EntityFrameworkCore.ChangeTracking;
using todoAPI.Models;

namespace todoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController: ControllerBase
    {
        // context variable
        private readonly ApplicationDbContext _context;

        // Declare class constructor
        public TodoController(
            ApplicationDbContext context
        )
        {
            _context = context;
        }

        // POST: apli/todo
        // This API is used to create a todo
        [HttpPost]
        public async Task<ActionResult> CreateTodo(
            [FromBody] TodoModel model
        )
        {
            // Todo implemented
        }

        // PUT: apit/todo.{id}
        // This API is used to update todo data
        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateTodo(
            Guid id,
            [FromBody] TodoModel model
        )
        {
            // To be implemented
        }

        // DELETE: api/todo/{id}
        // This API is used to delete todo data
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTodo()
        {
            // To be implemented
        }

        // GET: api/todo
        // This API is used to get todo data records
        public async Task<ActionResult<IEnumerable<TodoModel>>> GetTodos()

        {
            // To be implemented
        }

        // GET: api/todo/{id}
        // This API is used to get todo details
        public async Task<ActionResult<TodoModel>> GetTodos(
            Guid id
        )

        {
            // To be implemented
        }

    }
}