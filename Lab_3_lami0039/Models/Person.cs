using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace Lab3.Models
{
    public class Person

    {
      
        [Required]
        [StringLength(255)]
        [BindProperty]
        public string First_name
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [BindProperty]
        public string Last_name
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [BindProperty]
        public string Age
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [BindProperty]
        public string EmailAddress
        {
            get;
            set;
        }
        [BindProperty]
        public string Date_of_birth
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [HiddenInput]
        [BindProperty]
        public string password
        {
            get;
            set;
        }
        [Required]
        [StringLength(255)]
        [BindProperty]
        public string description
        {
            get;
            set;
        }





    }
}
