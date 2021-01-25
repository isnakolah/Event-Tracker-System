using System.Collections.Generic;

namespace poneaChallenge.TaskService
{
    public interface ITaskService
    {
        string StartServers();
        string StopServers();
        List<string> Report();
    }
}