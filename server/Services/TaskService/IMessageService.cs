using poneaChallenge.Models;

namespace poneaChallenge.TaskService
{
    public interface IMessageService
    {
        ServiceResponse<string> StartSomeServers();
    }
}