using System.Collections.Generic;
using poneaChallenge.Models;

namespace poneaChallenge.TaskService
{
    public interface ITaskService
    {
        ServiceResponse<int> StartServers();
        ServiceResponse<int> StopServers();
        ServiceResponse<int> ReportServers();
        ServiceResponse<List<string>> ReportLogs();
    }
}