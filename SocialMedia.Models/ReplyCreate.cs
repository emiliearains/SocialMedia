using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Models
{
    public class ReplyCreate
    {
        [Required]
        [MaxLength(200, ErrorMessage = "Maximum comment length is 200.")]
        public string Text { get; set; }
        [Required]
        public int CommentId { get; set; }
    }
}
