
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CreateComment
    {
        [Required]
        [MaxLength(200, ErrorMessage = "There are too many characters.")]
        public string Text { get; set; }
        [Required]
        public int PostId { get; set; }
    }
}
