using System;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class Nationality
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }        
    }
}