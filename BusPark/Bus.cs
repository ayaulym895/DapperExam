using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusPark
{
    [Table("buses")]
    public class Bus
    {
        [Key]
        public int Id { get; set; }
        public string Number{ get; set; }
        public int Price { get; set; }
        public int RepairForeignKey { get; set; }

        [ForeignKey("RepairForeignKey")]
        public Repair Repair { get; set; }
    }
}
