using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserAPI.Data;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpPost]
        public async void CreateUser(User user)
        {
            await _userRepository.CreateUser(user);

        }

        [HttpDelete("id")]
        public async void DeleteUser(int id)
        {
            await _userRepository.DeleteUserAsync(id);

        }
    }
}
