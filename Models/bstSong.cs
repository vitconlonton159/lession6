using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace bstLesson06.Models
{
    public class bstSong
    {
        [Key]
        public int Id { get; set; } 
        [Required]
        public string bstTitle { get; set; }
        [Required]
        public string bstAuthor { get; set; }
        [Required]
        public string bstArtist { get; set; }
        [Required]
        public int bstYearRelease { get; set; } 

    }
}