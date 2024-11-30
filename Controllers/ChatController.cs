using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace OllamaChatApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Post([FromBody] string message)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "ollama",
                    Arguments = $"run llama3 {message}",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            string result = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            return Ok(result);
        }
    }
}