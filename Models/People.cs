using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace version._0._1.Models
{
    public class People
    {
        [DataType(DataType.Date)]
        public int ID { get; set; }
        public String Name { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public bool Plan { get; set; }
        public DateTime TimeLeft { get; set; }
    }
}
