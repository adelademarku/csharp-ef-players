using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpEntityFrameworkPlayers
{
    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public  string Coach { get; set; } 
        public string Color { get; set; }

        public List<Player> Player { get; set; }
    }


}
