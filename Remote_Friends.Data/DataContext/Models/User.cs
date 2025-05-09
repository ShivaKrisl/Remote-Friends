using Remote_Friends.DataContext.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remote_Friends.Data.DataContext.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }

        [Required]
        public string UserName { get; set; }

        public string? ProfileUrl { get; set; }

        // Navigation Properties

        public ICollection<Post> Posts { get; set; } = new List<Post>();

    }
}
