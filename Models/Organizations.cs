using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CareMSApi.Model {

    [Table("Organization")]
    public class Organization
    {
        [Key]
        [Required]
        public int orgId { get; set; }

        [StringLength(50)]
        public String? organizationName { get; set; }

        [ForeignKey("Address")]
        public int addressRefId { get; set; }
        public Address? Address { get; set; }

        public bool isActive { get; set; }

        public ICollection<User>? User { get; set; }
    } 
}