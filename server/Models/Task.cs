using System;

namespace poneaChallenge.Models
{
    public class Task
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Precidence { get; set; }
        public int Interval { get; set; }

        internal static System.Threading.Tasks.Task Delay(int v)
        {
            throw new NotImplementedException();
        }
    }
}