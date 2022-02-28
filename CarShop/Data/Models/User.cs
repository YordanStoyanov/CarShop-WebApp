using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        public bool IsMechanic { get; set; }
    }
}
