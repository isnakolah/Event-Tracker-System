using poneaChallenge.Models;

namespace poneaChallenge.TaskService
{
    public class MessageService : IMessageService
    {
        private readonly ITaskService _taskService;

        public MessageService(ITaskService taskService)
        {
            _taskService = taskService;
        }
        public ServiceResponse<string> StartSomeServers()
        {
            var serviceResponse = new ServiceResponse<string>
            {
                Data = $"Start {_taskService.StartServers()} servers"
            };
            return serviceResponse;
        }
    }
}