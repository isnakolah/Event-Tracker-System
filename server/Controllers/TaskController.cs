using Microsoft.AspNetCore.Mvc;
using poneaChallenge.TaskService;

namespace poneaChallenge.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly ITaskService _taskService;
        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public IActionResult GetStartServers()
        {
            _taskService.StartTimingAsync();
            return Ok(_taskService.StartServers());
        }

    }
}