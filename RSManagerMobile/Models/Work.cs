using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSManagerMobile.Models
{
    public class Work
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(nameof(Client))]
        public int ClientId { get; set; }

        [ForeignKey(nameof(Mechanic))]
        public int MechanicId { get; set; }

        [ForeignKey(nameof(RepairShop))]
        public int RepairShopId { get; set; }

        [ForeignKey(nameof(Car))]
        public int CarId { get; set; }

        [ForeignKey(nameof(Part))]
        public int PartId { get; set; }
    }
}
