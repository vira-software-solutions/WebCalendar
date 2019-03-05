using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WC_WebApp.Controllers
{
    [Route("api/[controller]")]
    public class AuthController : Controller
    {
        // GET api/<controller>/5
        [HttpGet("{username}/{password}")]
        public IActionResult Get(string username, string password)
        {
            // TODO: Check if database contains username & password
            if (username.Equals("admin") && password.Equals("admin"))
            {
                return Ok(new ResponseMessage(){Message = "Success", Success = true});
            }


            return Ok(new ResponseMessage(){Message = "Username or password was wrong..", Success = false});
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        private struct ResponseMessage
        {
            public bool Success { get; set; }
            public string Message { get; set; }
        }
    }
}
