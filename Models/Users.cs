using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CareMSApi.Model {
    
    [Table("User")]
    public class User
    {

        [Key]
        [Required]
        public int userId { get; set; } // Replace with guid type

        [ForeignKey("Organization")]
        public int organizationRefId { get; set; }
        public Organization? Organization { get; set; }

        [Required]
        public List<String>? userType { get; set; }

        [Required]
        public String? displayName { get; set; }
        
        [Required]
        [StringLength(256)] // Adjust dependent upon moden hashing techniques in C#
        public String? password { get; set; }

        [Required]
        public String? firstName { get; set; }

        [Required]
        public String? lastName { get; set; }

        public bool isActive { get; set;} // Default value will be false until email validation confirmed
    }
}