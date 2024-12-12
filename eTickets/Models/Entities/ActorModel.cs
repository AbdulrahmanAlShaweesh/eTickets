using System.ComponentModel.DataAnnotations;


namespace eTickets.Models.Entities
{
    public class ActorModel
    {
        [Key]
        public int Id { get; set; }
        public string ActorImage { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; }   
    }
}
