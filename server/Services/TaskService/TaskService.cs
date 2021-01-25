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


        public int StartServers()
        {
            var rd = new Random();
            var randNum = rd.Next(10, 20);

            return randNum;
        }

        public int StopServers()
        {
            var rd = new Random();
            var randNum = rd.Next(5, ReportServers());

            return randNum;
        }
        public int ReportServers()
        {
            var k = 20;
            return k;
        }

        public List<string> ReportLogs()
        {
            throw new NotImplementedException();
        }
    }
}