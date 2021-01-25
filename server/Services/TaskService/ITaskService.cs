using System.Collections.Generic;

namespace poneaChallenge.TaskService
{
    public interface ITaskService
    {
        int StartServers();
        int StopServers();
        int ReportServers();
        List<string> ReportLogs();
    }
}