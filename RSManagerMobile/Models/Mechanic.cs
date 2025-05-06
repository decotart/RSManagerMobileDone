using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSManagerMobile.Models
{
    public class Mechanic
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Adres {  get; set; }

        public string Phone { get; set; }

        public string Category { get; set; }
    }
}
