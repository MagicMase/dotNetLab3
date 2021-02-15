using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetLab3.Models
{
    public class Person
    {

        [Required]
        public string firstName
        {
            get;
            set;
        }

        [Required]
        public string lastName
        {
            get;
            set;
        }

        [Required]
        public int Age
        {
            get;
            set;
        }

        [Required]
        public string Email
        {
            get;
            set;
        }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday
        {
            get;
            set;
        }

        [Required]
        public string Password
        {
            get;
            set;
        }
        [Required]
        public string Description
        {
            get;
            set;
        }
    }
}
