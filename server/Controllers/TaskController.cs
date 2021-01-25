using Microsoft.AspNetCore.Mvc;
using poneaChallenge.TaskService;

namespace poneaChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetActions()
        {
            return Ok(_taskService.StartServers());
        }
    }
}