using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace MVCLab23.Models
{
    public partial class Users1
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        [StringLength(10, MinimumLength = 3)]
        public string UserName { get; set; }
        [MinLength(3)]
        [MaxLength(10)]
        [Required]
        public string Password { get; set; }
        [Required]
        public decimal? Money { get; set; }
    }
}
