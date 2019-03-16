using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNextAPI.Dtos
{
    public class UserForLoginDto
    {
        public string UserEmail { get; set; }
        public string Password { get; set; }
    }
}
