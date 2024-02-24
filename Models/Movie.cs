using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eTickets.Data.Enums;

namespace eTickets.Models
{
    public class Movie
    {
        [Key] 
        public int MovieId { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public MovieCategory MovieCategory { get; set; }

        public List<Actor_Movie> Actor_Movies { get; set; }
        public Cinema Cinema { get; set; }
        [ForeignKey("CinemaId")]
        public int CinemaId {  get; set; }
        public Producer Producer { get; set; }
        [ForeignKey("ProducerId")]
        public int ProducerId { get; set; }


    }
}
