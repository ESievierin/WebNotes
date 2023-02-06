using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration.UserSecrets;
using WebNotes.API.Models;
using WebNotes.BLL.DTO;
using WebNotes.BLL.Interfaces;
using WebNotes.BLL.Service;

namespace WebNotes.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService userservice) => 
            userService = userservice;


        [HttpPost("reg")]
        public bool Register([FromBody] UserRequest request) =>
            userService.Registration(request.Login, request.Password);

        [HttpPost("log")]
        public int Login([FromBody] UserRequest request) =>
            userService.Login(request.Login, request.Password);


        [HttpGet("{id}")]
        public UserDTO Get(int id) =>    
            userService.Get(id);

        public void Update(int id, [FromBody] UserRequest request) =>
          userService.Update(id, new UserDTO(id, request.Login, request.Password));


        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            userService.Delete(id);
        }
    }
}
