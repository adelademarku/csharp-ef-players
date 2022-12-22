using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace csharpEntityFrameworkPlayers
{
   
    public class Player
    {
        public int PlayerId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public int Score { get; set; }

        [Column("number_of_matches")] 
        public int NumberMatches { get; set; }
        [Column("number_of_matches_won")] 
        public int NumberMatchesWon { get; set; }

       
        public Team Team { get; set; }




        public void PrintPlayer()
        {
            Console.WriteLine("----------Player----------" + "\n" + Name + " " + Surname + "\n" + "Score: " + Score + "\n"
                + "Number of matches: " + NumberMatches + "\n"
                + "Number of matches won: " + NumberMatchesWon);
        }
    }
}
