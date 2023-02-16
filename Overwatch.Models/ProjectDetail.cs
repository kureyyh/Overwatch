using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overwatch.Models
{
    public class ProjectDetail
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        [Required]
        public string ConnectionString { get; set; }    
    }
}
