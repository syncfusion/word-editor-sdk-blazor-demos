using BlazorDemos.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
namespace BlazorDemos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTokensController : ControllerBase
    {
        private readonly IWebHostEnvironment _env;
        private UserTokenService userToken { get; set; }
        public UserTokensController(IWebHostEnvironment env, UserTokenService user)
        {
            _env = env;
            userToken = user;
        }
        [HttpGet("get_remaining_tokens/{userId}")]
        public async Task<IActionResult> GetRemainingTokens(string userId)
        {
            string filePath = Path.Combine(_env.ContentRootPath, "user_tokens.json");
            int remainingTokens = await userToken.GetRemainingTokensAsync(userId);
            string alertMessage = await userToken.ReturnAlertMessage(userId);
            if (remainingTokens <= 300)
            {
                return Ok(new { remainingTokens, alertMessage });
            }
            await userToken.UpdateTokensAsync(userId, (int)(remainingTokens - 550));
            return Ok(new { remainingTokens, alertMessage });
        }
    }
}