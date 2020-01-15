using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace version._0._1.Models
{
    public class Trans
    {
        [DataType(DataType.Date)]
        public int ID { get; set; }
        public String Name { get; set; }
        public decimal Amnt { get; set; }
        public DateTime Date { get; set; }
        public String Nature { get; set; }
        public String Cat { get; set; }
        public int Pattern { get; set; }
        public String Notes { get; set; }
    }
}
