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
        public IList<User> Users { get; } = new List<User>();
        public IList<Computer> Installed { get; } = new List<Computer>();
        public IList<Genre> GamesGenres { get; } = new List<Genre>();
    }
}
