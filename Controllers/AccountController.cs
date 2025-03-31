    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    namespace Librabry_ting_ting.Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class AccountController : ControllerBase
        {
            private readonly SignInManager<IdentityUser> _signInManager;

            public AccountController(SignInManager<IdentityUser> signInManager)
            {
                _signInManager = signInManager;
            }

            [HttpPost("login")]
            public async Task<IActionResult> Login([FromBody] LoginModel model)
            {
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, isPersistent: false, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        return Ok(new { message = "Login successful" });
                    }
                    return Unauthorized(new { message = "Invalid login attempt" });
                }
                return BadRequest(ModelState);
            }
        }

        public class LoginModel
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
    }