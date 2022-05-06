using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CareMSApi.Model {

    public class Address
    {
        [Key]
        [Required]
        public int addressId { get; set; }

        public List<String>? addressType { get; set; }

        [StringLength(100)]
        public String? street1 { get; set; }

        [StringLength(100)]
        public String? street2 { get; set; }

        [StringLength(50)]
        public String? city { get; set; }

        [StringLength(2)]
        public String? state { get; set; }
        
        [StringLength(5)]
        public String? zip5 { get; set; }

        [StringLength(4)]
        public String? zip4 { get; set; } 

        public ICollection<Organization>? Organization { get; set; }
        public ICollection<User>? User { get; set; }
    }
}