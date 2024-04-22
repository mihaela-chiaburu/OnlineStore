using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using eUseControl.Domain.Enums;

namespace eUseControl.Domain.Entities.User.DBModel
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 8)]
        public string Password { get; set; }

        public UserRole Level { get; set; }
    }
}
