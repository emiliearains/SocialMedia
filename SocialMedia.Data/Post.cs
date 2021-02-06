using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        //[Required]
        // ................virtual list of Comments
        public virtual List<Comment> Comments { get; set; } = new List<Comment>();

        [Required]
        public Guid AuthorId { get; set; }
    }
}
