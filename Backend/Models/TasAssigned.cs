using Backend.Models;
using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Models
{
    public class TasAssigned
    {
        [Key]
        public int TaskId { get; set; }

        public string TaskName { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public DateTime Deadline { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public string Description { get; set; }

        public bool TaskStatus { get; set; }

        public int Scores { get; set; }

        [ForeignKey("Documents")]
        public int DocumentId { get; set; }

        public virtual User User { get; set; }

        public virtual Documents Documents { get; set; }

    }
}
