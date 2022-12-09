using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataModels.Entities
{
    public class Computer : EntityBase
    {
        public string CPU { get; set; } = null!;
        public string GPU { get; set; } = null!;
        public string RAM { get; set; } = null!;
        public string Motherboard { get; set; } = null!;
        public string Disk { get; set; } = null!;
        public int DiskSizeMb { get; set; }
        public IList<Game> InstalledGames { get; } = new List<Game>();
        public IList<Application> InstalledApps { get; } = new List<Application>();
        [ForeignKey("FK_ZoneId")]
        public Guid ZoneId { get; set; }
        public Zone Zone { get; set; } = null!;
    }
}
