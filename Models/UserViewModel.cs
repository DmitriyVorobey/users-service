using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSUser.Models
{
    public class UserViewModel
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string Email { set; get; }
    }
}
