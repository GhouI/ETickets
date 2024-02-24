using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor 
    {
        public int ActorId { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public List<Actor_Movie> Movies { get; set; }

        // Additional properties or methods specific to the Actor class can be added here
        public List<Actor_Movie> Actor_Movie { get; set; }
    }
}
