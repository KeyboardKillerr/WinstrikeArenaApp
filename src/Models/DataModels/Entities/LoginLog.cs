using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels.Entities
{
    public class LoginLog 
    {
        public Computer Computer { get; set; } = null!;
        public DateTime LoginDateTime { get; set; }
        [Key]
        [ForeignKey("FK_UserId")]
        public Guid Id { get; set; } //UserId
        public User User { get; set; } = null!;
        [ForeignKey("FK_ComputerId")]
        public Guid ComputerId { get; set; }
    }
}
