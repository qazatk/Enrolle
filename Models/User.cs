using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace QazATK.Models
{
    public class User : IdentityUser
    {
        [Key]
        private int UserId;

        public int GetId()
        {
            return UserId;
        }

        public void SetId(int value)
        {
            UserId = value;
        }

        private string userName;

        public string GetUserName()
        {
            return userName;
        }

        internal void SetUserName(string value)
        {
            userName = value;
        }
    }
}