using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class CommentCreate
    {
        [Required]
        [MaxLength(1000, ErrorMessage = "Maximum comment length is 1000.")]
        public string Text { get; set; }
        
        [Required]
        public int PostId { get; set; }
        public int CommentId { get; set; }
    }
}
