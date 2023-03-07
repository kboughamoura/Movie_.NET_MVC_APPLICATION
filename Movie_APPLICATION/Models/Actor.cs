using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_APPLICATION.Models
{
    public class Actor
    {
        [Key]
        public int ID { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string bio { get; set; }

        //Relationships:

        public List<Actor_Movie> Actors_Movies { get; set; }

    }
}
