using System;
using System.Collections.Generic;
using poneaChallenge.Models;

namespace poneaChallenge.TaskService
{
    public class TaskService : ITaskService
    {
        private readonly static List<Task> tasks = new List<Task>
        {
            new Task
            {
                Name = "START",
                Interval = 30,
                Precidence = 1,
                Color = "black"
            },
            new Task
            {
                Name = "STOP",
                Interval = 40,
                Precidence = 2,
                Color = "yellow"
            },
            new Task
            {
                Name = "REPORT",
                Interval = 50,
                Precidence = 3,
                Color = "pink"
            }
        };

        private static List<Task> report = new List<Task>();

        private static int runningServers = 0;

        private static Random rd = new Random();
        public ServiceResponse<int> StartServers()
        {
            var serviceResponse = new ServiceResponse<int>();
            var randNum = rd.Next(10, 20);
            runningServers += randNum;
            serviceResponse.Data = randNum;

            return serviceResponse;
        }

        public ServiceResponse<int> StopServers()
        {
            var serviceResponse = new ServiceResponse<int>();
            var randNum = rd.Next(5, ReportServers().Data);
            runningServers += randNum;
            serviceResponse.Data = randNum;

            return serviceResponse;
        }
        public ServiceResponse<int> ReportServers()
        {
            // TODO Get the remaining running servers from the db
            var serviceResponse = new ServiceResponse<int>();
            serviceResponse.Data = runningServers;
            return serviceResponse;
        }

        public ServiceResponse<List<string>> ReportLogs()
        {
            throw new NotImplementedException();
        }

        public async System.Threading.Tasks.Task StartTimingAsync()
        {
            do
            {
                StartServers();
                await Task.Delay(30000);
                StopServers();
                await Task.Delay(30000);
                ReportServers();
                await Task.Delay(30000);
            } while (true);
        }
    }
}