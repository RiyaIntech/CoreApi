using Microsoft.AspNetCore.Mvc;

namespace CoreApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UsersController()
        {

        }
        [HttpGet]
        public List<Users> GetUser()
        {
            List<Users> _users = new List<Users>()
            {
                new Users()
                {
                    Name = "Riya",
                    Email = "Riya@gmail.com",
                    Password = "riya123"
                }
            };
            return _users;
        }

    }
    public class Users
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
