using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpEntityFrameworkPlayers
{
    public class Context : DbContext
    {
        public DbSet<Player> Players { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Database=PlayersDb;Integrated Security=True; TrustServerCertificate=True");
        }



    }

}
