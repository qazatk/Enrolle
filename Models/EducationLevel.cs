using System;
using System.ComponentModel.DataAnnotations;

/* Уровень образования */

namespace QazATK.Models
{
    public class EducationLevel
    {
        [Key]
        public int Id { get; set; }
        public string Level { get; set; }
    }
}