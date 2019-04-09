using System;
using System.ComponentModel.DataAnnotations;

/* */

namespace QazATK.Models
{
    public class Resident
    {
        [Key]
        public int ResidentId { get; internal set; }
        public string ResidentName { get; internal set; }
    }
}