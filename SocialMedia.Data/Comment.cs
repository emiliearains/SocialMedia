using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia.Data
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public Guid AuthorId { get; set; }

        [ForeignKey(nameof(Posts))]
        public int PostId { get; set; }
        public virtual Post Posts{ get; set; }

        //[ForeignKey(nameof(Reply))]
        //public int ReplyId { get; set; }
        //public virtual Reply Replies { get; set; }
        public virtual List<Reply> Reply { get; set; } = new List<Reply>();


                            // ..........................virtual list of Replies
                            // ..........................Foreign Key to Post via ID with virtual post

    }
}
