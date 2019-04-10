using System;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class Enrollee
    {
        [Key]
        public int Id { get; set; }

        public virtual int GetId()
        {
            return Id;
        }
        public virtual void SetId(int value)
        {
            Id = value;
        }

        private string Firstname { get; set; }

        public virtual string GetFirstname()
        {
            return Firstname;
        }

        public virtual void SetFirstname(string value)
        {
            Firstname = value;
        }
        private string Lastname { get; set; }

        public string GetLastname()
        {
            return Lastname;
        }
        private string Patronimyc { get; set; }

        public string GetPatronimyc()
        {
            return Patronimyc;
        }


        public string Email { get; set; }
        public int Iin { get; set; }

        //Добавить объект для ввода для ном. телефона

    }
}