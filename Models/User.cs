using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace TreeniApp.Models
{
    public class User
    {

       
      

            public int UserId { get; set; }
            public string Username { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

           
       
    }
}
