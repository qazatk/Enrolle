using System;
using System.ComponentModel.DataAnnotations;

/* Предыдущиее образование */

namespace QazATK.Models
{
    public class PreviousEducation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }        
    }
}