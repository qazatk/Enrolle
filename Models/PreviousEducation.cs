using System;
using System.ComponentModel.DataAnnotations;

/* Предыдущиее образование */

namespace QazATK.Models
{
    public class PreviousEducation
    {
        [Key]
        public int Id { get; internal set; }
        public string Name { get; internal set; }        
    }
}