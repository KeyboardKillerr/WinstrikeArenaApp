using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Entities
{
    public class Game : EntityBase
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public int SizeMb { get; set; }
        public IList<User> Users { get; set; } = new List<User>();
        public IList<Computer> Installed { get; set; } = new List<Computer>();
        public IList<Genre> GamesGenres { get; set; } = new List<Genre>();
    }
}
