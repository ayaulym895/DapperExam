using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusPark
{
    [Table("mecBusRelations")]
    public class MecBusRelations
    {
        public int MechanicId { get; set; }
        public int BusId { get; set; }
        public ICollection<Mechanic> Mechanics { get; set; }
        public ICollection<Bus> Buses { get; set; }
    }
}
