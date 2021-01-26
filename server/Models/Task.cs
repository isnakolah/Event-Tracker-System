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

        public int Running { get; set; } = 0;

        [DataType(DataType.Date)]
        public DateTime CurrentTime { get; } = DateTime.UtcNow;

        internal static System.Threading.Tasks.Task Delay(int v)
        {
            throw new NotImplementedException();
        }
    }
}