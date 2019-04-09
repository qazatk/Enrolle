using System;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class Enrollee
    {
        [Key]
        public int Id { get; set; }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronimyc { get; set; }
        public string Email { get; set; }
        public int Iin { get; set; }

    }
}