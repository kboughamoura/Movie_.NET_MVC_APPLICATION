using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_APPLICATION.Models
{
    public class Cinema
    {
        [Key]
        public int ID { get; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships:
        public List<Movie> Movies { get; set; }

    }
}
