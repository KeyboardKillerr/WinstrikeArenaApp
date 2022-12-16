using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Entities
{
    public class Genre : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public IList<Game> Games { get; set; } = new List<Game>();
    }
}
