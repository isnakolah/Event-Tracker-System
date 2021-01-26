using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using poneaChallenge.Models;

namespace poneaChallenge.TaskService
{
    public class TaskService : ITaskService
    {

        private readonly IOptions<MvcOptions> _mvcOptions;
        private readonly TaskIssuedContext _context;
        public TaskService(TaskIssuedContext context, IOptions<MvcOptions> mvcOptions)
        {
            _context = context;
            _mvcOptions = mvcOptions;
        }
        private readonly static List<TaskIssued> tasksIssued = new List<TaskIssued>
        {
            new TaskIssued
            {
                Name = "START",
                Interval = 30,
                Precidence = 1,
                Color = "black"
            },
            new TaskIssued
            {
                Name = "STOP",
                Interval = 40,
                Precidence = 2,
                Color = "yellow"
            },
            new TaskIssued
            {
                Name = "REPORT",
                Interval = 50,
                Precidence = 3,
                Color = "pink",
            }
        };
        private static List<TaskIssued> report = new List<TaskIssued>();

        private static Random rd = new Random();
        public async Task<ServiceResponse<int>> StartServers()
        {
            var serviceResponse = new ServiceResponse<int>();
            var randNum = rd.Next(10, 20);

            var task = tasksIssued[0];
            task.StartedOrStopped = randNum;


            serviceResponse.Data = randNum;

            return serviceResponse;
        }

        public ServiceResponse<int> StopServers()
        {
            var serviceResponse = new ServiceResponse<int>();
            var randNum = rd.Next(5, ReportServers().Data);
            // runningServers += randNum;
            serviceResponse.Data = randNum;

            return serviceResponse;
        }
        public ServiceResponse<int> ReportServers()
        {
            // TODO Get the remaining running servers from the db
            var serviceResponse = new ServiceResponse<int>();
            // serviceResponse.Data = runningServers;
            return serviceResponse;
        }

        public ServiceResponse<List<string>> ReportLogs()
        {
            throw new NotImplementedException();
        }
    }
}