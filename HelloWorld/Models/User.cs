using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        [Index("idx_users_name", IsUnique = true)]
        public string Name { get; set; }
    }
}