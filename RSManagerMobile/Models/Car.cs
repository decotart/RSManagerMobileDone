using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSManagerMobile.Models
{
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Power { get; set; }

        public int Year { get; set; }

        public string Color { get; set; }
    }
}
