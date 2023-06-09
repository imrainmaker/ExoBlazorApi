using System.ComponentModel.DataAnnotations;

namespace Blazor.API.Dtos
{
    public class AddGame
    {
        [Required] 
        public string Titre { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateTime DateDeSortie { get; set; }
        [Required]
        [Range(0,5)]
        public int Note { get; set; }
    }
}
