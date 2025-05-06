using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace RSManagerMobile.Models
{
    public class Part
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public int Coast {  get; set; }

        public string DateOfIssue { get; set; }

        public string Category { get; set; }

        public string CompletionDate { get; set; }
    }
}
