using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiCore.Controllers
{
    [Route("api/[controller]")]
    public class TodoItemsController : Controller
    {

        private readonly TodoContext _context;

        public TodoItemsController(TodoContext context)
        {
            _context = context;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<TodoItem> Get()
        {
            return _context.TodoItems;
        }
        // GET api/TodoItems/5
        [HttpGet("{id}")]
        public async Task<IAsyncResult> GetTodoItem([FromRoute]long id)
        {
            if (!ModelState.IsValid)
            {
                return (System.IAsyncResult)BadRequest(ModelState);
            }

            var todoitem = await _context.TodoItems.SingleOrDefaultAsync(p => p.Id == id);
            if(todoitem ==null)
            {
                return (System.IAsyncResult)NotFound();
            }
            return (System.IAsyncResult)Ok(todoitem);
        }

        // POST api/values
        [HttpPost]
        public async Task<IActionResult> PostTodoItem([FromBody]TodoItem todoItem)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _context.TodoItems.Add(todoItem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
        }

        // PUT api/TodoItems/5
        [HttpPut("{id}")]
        public async Task<IAsyncResult> PutTodoItem(int id, [FromBody]TodoItem todoItem)
        {
            if(!ModelState.IsValid)
            {
                return (System.IAsyncResult)BadRequest(ModelState);
            }
            if(id != todoItem.Id)
            {
                return (System.IAsyncResult)BadRequest();
            }

             _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return (System.IAsyncResult)BadRequest(ex.Message);
            }

            return null;

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
