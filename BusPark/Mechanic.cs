using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusPark
{
    [Table("mechanics")]
    public class Mechanic
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string WorkExperience { get; set; }
        //[ForeignKey]        

        public int BusForeignKey { get; set; }

        [ForeignKey("BusForeignKey")]
        public Bus Bus { get; set; }
    }
}
