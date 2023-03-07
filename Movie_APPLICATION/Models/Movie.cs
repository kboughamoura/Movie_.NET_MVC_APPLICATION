using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_APPLICATION.Models
{
    public class Movie
    {

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //relationship
        public List<Actor_Movie> Actors_Movies { get; set; }


        //CINEMA
        public int CinemaId { get; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set;  }


        //CINEMA
        public int ProducerId { get; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }


    }
}
