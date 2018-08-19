using AspNetCoreVideo.Models;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreVideo.Entities
{
    public class Video
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(80)]
        public string Title { get; set; }

        [Display(Name = "Film Genre")]
        public Genres Genre { get; set; }
      
    }
}
