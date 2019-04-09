using System;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class EducationLevel
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }
    }
}