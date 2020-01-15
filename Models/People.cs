using System;
using System.ComponentModel.DataAnnotations;

namespace version._0._1.Models
{
    public class People
    {
        [DataType(DataType.Date)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool Plan { get; set; }
        public DateTime TimeLeft { get; set; }
    }
}
