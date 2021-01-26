using System;
using System.ComponentModel.DataAnnotations;

namespace poneaChallenge.Models
{
    public class Task
    {
        [Key]
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        public int Precidence { get; set; }

        public int Interval { get; set; }

        internal static System.Threading.Tasks.Task Delay(int v)
        {
            throw new NotImplementedException();
        }
    }
}