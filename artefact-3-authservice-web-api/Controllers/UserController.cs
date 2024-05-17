using Microsoft.AspNetCore.Mvc;
using Supabase;
using System.Linq;
using System.Threading.Tasks;
using AuthService.Models;
using AuthService.Requests;
using AuthService.Utilities;

namespace AuthService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly Supabase.Client client;

        public UserController(Supabase.Client supabase)
        {
            client = supabase;
        }

        [HttpGet("/users")]
        public async Task<IActionResult> GetAllUsers()
        {
            try
            {
                var result = await client.From<User>().Get();
                var users = result.Models;
                return Ok(users);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while fetching users: {ex.Message}");
                return StatusCode(500, "An error occurred while fetching users.");
            }
        }

        [HttpPost("/users")]
        public async Task<IActionResult> CreateUser([FromBody] CreateUserRequest request) 
        {
            PasswordUtility passwordUtility = new PasswordUtility();
            var user = new User
            {
                Email = request.Email,
                Password = passwordUtility.HashPassword(request.Password),
            };

            var response = await client.From<User>().Insert(user);
            var newUser = response.Models.FirstOrDefault();

            return newUser != null ? Ok(newUser) : StatusCode(500, "Failed to create the user.");
        }

        [HttpGet("/users/{Id}")]
        public async Task<IActionResult> GetUserById(string Id)
        {
            try
            {
                var result = await client
                    .From<User>()
                    .Select("*")
                    .Where(user => user.Id == Id)
                    .Get();

                if (result == null)
                {
                    return NotFound($"User with ID {Id} not found.");
                }

                var user = result.Model;

                return Ok(user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while fetching the user with ID {Id}: {ex.Message}");
                return StatusCode(500, $"An error occurred while fetching the user with ID {Id}.");
            }
        }

        [HttpPut("/users/{Id}")]
        public async Task<IActionResult> UpdateUserById(string Id, [FromBody] CreateUserRequest request)
        {
            try
            {
                var model = await client
                    .From<User>()
                    .Where(user => user.Id == Id)
                    .Single();

                if (model == null)
                {
                    return NotFound($"User with ID {Id} not found.");
                }

                model.Email = request.Email;
                model.Password = request.Password;

                await model.Update<User>();
                return Ok($"Successfully updated user with ID: {Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while updating the user with ID {Id}: {ex.Message}");
                return StatusCode(500, $"An error occurred while updating the user with ID {Id}.");
            }
        }

        [HttpDelete("/users/{Id}")]
        public async Task<IActionResult> DeleteUserById(string Id)
        {
            try
            {
                await client
                    .From<User>()
                    .Where(user => user.Id == Id)
                    .Delete();

                return Ok($"Successfully deleted new user with ID: {Id}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while deleting the user with ID {Id}: {ex.Message}");
                return StatusCode(500, $"An error occurred while deleting the user with ID {Id}.");
            }
        }
    }
}
