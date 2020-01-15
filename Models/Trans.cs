using System;
using System.ComponentModel.DataAnnotations;

namespace version._0._1.Models
{
    public class Trans
    {
        [DataType(DataType.Date)]
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Amnt { get; set; }
        public DateTime Date { get; set; }
        public string Nature { get; set; }
        public string Cat { get; set; }
        public int Pattern { get; set; }
        public string Notes { get; set; }
    }
}
