using System.ComponentModel.DataAnnotations;

namespace DiscGolfWebAPI.Models
{
    public class Player
    {
        [Key]
        public uint Id { get; set; }
        [Required]
        public required string Name { get; set; }

        public Player() { }
    }
}
