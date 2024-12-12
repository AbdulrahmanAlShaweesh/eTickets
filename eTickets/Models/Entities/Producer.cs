using System.ComponentModel.DataAnnotations;

namespace eTickets.Models.Entities
{
    public class Producer
    {
        [Key    ]
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public string Image { get; set; } = String.Empty;

        public string Biography { get; set; } = String.Empty;
    }
}
