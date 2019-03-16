using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNextAPI.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "You must specify a password between 4 and 10 characters")]
        public string Password { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

       
        public DateTime Created { get; set; }
        public DateTime LastActive { get; set; }

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
    }
}
