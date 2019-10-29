using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusPark
{
    [Table("repairs")]
    public class Repair
    {
        [Key]
        public int Id { get; set; }
        public bool InRepair { get; set; }
    }
}
