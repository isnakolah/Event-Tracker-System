using System.Collections.Generic;
using System.Threading.Tasks;
using poneaChallenge.Models;

namespace poneaChallenge.TaskService
{
    public interface ITaskService
    {
        Task<ServiceResponse<int>> StartServers();
        ServiceResponse<int> StopServers();
        ServiceResponse<int> ReportServers();
        ServiceResponse<List<string>> ReportLogs();
    }
}