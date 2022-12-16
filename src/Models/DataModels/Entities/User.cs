using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Entities
{
    public class User : EntityBase
    {
        public string NickName { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Birhtday { get; set; }
        public string? FullName { get; set; }
        public int PhoneNumber { get; set; }
        public bool Administartor { get; set; }
        public IList<Game> FavoriteGames { get; set; } = new List<Game>();
        public IList<Rate> Rates { get; set; } = new List<Rate>();
    }
}
