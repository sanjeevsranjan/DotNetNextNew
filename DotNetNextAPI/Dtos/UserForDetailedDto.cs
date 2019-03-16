using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetNextAPI.Dtos
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string UserEmail { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
    }
}
