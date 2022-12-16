using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Entities
{
    public class Application : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int SizeMb { get; set; }
        public IList<Computer> Installed { get; set; } = new List<Computer>();
    }
}
