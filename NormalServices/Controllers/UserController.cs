using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NormalServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NormalServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly MicroserviceDbContext db;

        public UserController(MicroserviceDbContext Db)
        {
            db = Db; 
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return db.Users.ToList();
        }

        [HttpGet("{id}", Name ="Get")]
        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        // POST api/<UserController>
        [HttpPost]
        public  IActionResult  Post([FromBody] User value)
        {
            try
            {
                db.Users.Add(value);
                db.SaveChanges();
                return StatusCode(StatusCodes.Status201Created, value);            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        //Update
      
       





    }
}
