using Microsoft.AspNetCore.Mvc;
using poneaChallenge.TaskService;

namespace poneaChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;

        public MessagesController(IMessageService messageService)
        {
            _messageService = messageService;
        }

        [HttpGet]
        [Route("start")]
        public IActionResult GetStartServerMessage()
        {
            return Ok(_messageService.StartSomeServers());
        }

        // [HttpGet]
    }
}