using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels.Entities
{
    public class Rate : EntityBase
    {
        public string Name { get; set; } = null!;
        public int Hours { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Price { get; set; }
        public IList<User> Users { get; } = new List<User>();
        [ForeignKey("FK_ZoneId")]
        public Guid ZoneId { get; set; }
        public Zone Zone { get; set; } = null!;
    }
}
