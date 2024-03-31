using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FreelancersApp.Data;
using FreelancersApp.Models;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.EntityFrameworkCore;

namespace FreelancersApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        //get
        [HttpGet]
        public JsonResult Get(int id)
        {
            var result = _context.USERS.Find(id);

            if (result == null)
                return new JsonResult(NotFound());

            return new JsonResult(Ok(result));
        }

        //getall
        [HttpGet()]
        public JsonResult GetAll()
        {
            var result = _context.USERS.ToList();
            return new JsonResult(Ok(result));

        }

        [HttpPost]
        public JsonResult Register(User user)
        {
            if (user.id == 0)
            {
                _context.USERS.Add(user);
            }
            else
            {
                var userInDb = _context.USERS.Find(user.id);

                if (userInDb == null)
                    return new JsonResult(NotFound());

                // Update the properties of the existing user with values from the new user
                userInDb.username = user.username;
                userInDb.email = user.email;
                userInDb.phone = user.phone;
                userInDb.skillset = user.skillset;
                userInDb.hobby = user.hobby;
            }

            _context.SaveChanges();
            return new JsonResult(Ok(user));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, User user)
        {
            if (id != user.id)
            {
                return BadRequest();
            }

            _context.Entry(user).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var user = _context.USERS.Find(id);
            if (user == null)
            {
                return NotFound();
            }

            _context.USERS.Remove(user);
            _context.SaveChanges();

            return NoContent();
        }

        private bool UserExists(int id)
        {
            return _context.USERS.Any(e => e.id == id);
        }
    }

}
