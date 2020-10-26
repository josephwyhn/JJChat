﻿using System.ComponentModel.DataAnnotations;

namespace JJChatAPI.Models
{
    public class User
    {
        [Key]
        public long Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ChatMessage Message { get; set; }
    }
}