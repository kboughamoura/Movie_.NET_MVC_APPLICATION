using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_APPLICATION.Models
{
    public class Actor_Movie
    {
        public int MovieID { get; set; } 
        public Movie Movie { get; set; }

        public Actor Actor { get; set; }
        public int ActorID { get; set; }
    }
}
