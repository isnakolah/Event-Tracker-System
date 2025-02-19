using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace poneaChallenge.Models
{
    public class TaskIssued
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public string Color { get; set; }

        public int Precidence { get; set; }

        public int Interval { get; set; }

        public int StartedOrStopped { get; set; } = 0;

        [DataType(DataType.Date)]
        public DateTime CurrentTime { get; } = DateTime.UtcNow;

    }
}