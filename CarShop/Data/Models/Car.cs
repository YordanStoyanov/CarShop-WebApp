using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Data.Models
{
    public class Car
    {
        [Key]
        [Required]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(20)]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public string PictureUrl { get; set; }

        [Required]
        public string PlateNumber { get; set; }

        [Required]
        public string OwnerId { get; set; }

        [ForeignKey(nameof(OwnerId))]
        public User Owner { get; set; }

        public ICollection<Issue> Issues { get; set; } = new List<Issue>();
    }
}
