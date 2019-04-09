using System;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }

        public string Lastname { get; set; }
    }
}