/* Язык обучения  */

using System;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class InstructionLanguage
    {
        [Key]
        public int Id { get; set; }
        public string Lang { get; set; }
    }
}