using Remote_Friends.Data.DataContext.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Remote_Friends.DataContext.Models
{
    public class Post
    {
        [Key]
        public Guid PostId { get; set; }

        [Required(ErrorMessage ="Post Content is Required")]
        public string Content { get; set; }

        public string? ImageUrl { get; set; }

        public uint NoOfReports { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastUpdatedAt { get; set; }

        // Navigation Properties
       
        public Guid UserId { get; set; }

        public User user { get; set; }
    }
}
