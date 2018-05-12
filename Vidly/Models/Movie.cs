using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Movie
    {
        
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1, 20)]
        public int Stock { get; set; }

        [Display(Name = "Genre")]
        [Required]
        public int Genre_Id { get; set; }

        public Genres Genres { get; set; }

        public byte NumberAvailable { get; set; }
    }
}