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


        public ServiceResponse<int> StartServers()
        {
            var serviceResponse = new ServiceResponse<int>();
            var rd = new Random();
            serviceResponse.Data = rd.Next(10, 20);

            return serviceResponse;
        }

        public ServiceResponse<int> StopServers()
        {
            var serviceResponse = new ServiceResponse<int>();
            var rd = new Random();
            serviceResponse.Data = rd.Next(5, ReportServers().Data);

            return serviceResponse;
        }
        public ServiceResponse<int> ReportServers()
        {
            // TODO Get the remaining running servers from the db
            var serviceResponse = new ServiceResponse<int>();
            return serviceResponse;
        }

        public ServiceResponse<List<string>> ReportLogs()
        {
            throw new NotImplementedException();
        }
    }
}