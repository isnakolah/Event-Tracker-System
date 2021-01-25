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

        public List<string> Report()
        {
            var rd = new Random();
        }

        public string StartServers()
        {
            throw new System.NotImplementedException();
        }

        public string StopServers()
        {
            throw new System.NotImplementedException();
        }
    }
}