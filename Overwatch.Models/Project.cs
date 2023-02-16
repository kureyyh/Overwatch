using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrganisationId { get; set; }

        public Organisation Organisation { get; set; }

        [Required]
        public string Name { get; set; }    

    }
}
