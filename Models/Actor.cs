using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor : IActorProducer
    {
        public int Id { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        // Additional properties or methods specific to the Actor class can be added here
    }
}
