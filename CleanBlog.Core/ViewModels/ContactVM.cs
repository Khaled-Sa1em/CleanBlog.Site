﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanBlog.Core.ViewModels
{
    public class ContactVM
    {
        [Required(ErrorMessage = "Please enter your name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [EmailAddress(ErrorMessage = "Your must enter a vaild email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your message.")]
        [MaxLength(500, ErrorMessage = "Your message must be no longer than 500 characters.")]
        public string Message { get; set; }
        public int ContactFormId { get; set; }
    }
}
