using System.ComponentModel.DataAnnotations;

namespace Movie_APPLICATION.Models
{
    public class MovieCategory
    {
        [Key]
        public int ID { get; set; }
        public string CategoryName { get; set; }
    }
}