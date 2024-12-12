using System.ComponentModel.DataAnnotations;

namespace eTickets.Models.Entities
{
    public class CinemaModel
    {
        [Key]
        public int Id { get; set; }

        public String Logo = String.Empty;

        public string Name = String.Empty;  

        public string Description = String.Empty;
    }
}
