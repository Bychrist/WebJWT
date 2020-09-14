using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebJWT.Models
{
    public class Project
    {
        [Key]
        public int projectID { set; get; }
        public string projectName { get; set; }
        public DateTime dateOfStart { get; set; }
        public int teamSize { get; set; }
    }
}
