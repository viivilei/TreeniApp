using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.Maui.ApplicationModel.Permissions;

namespace TreeniApp.Models
{
    public class Goal
    {

     

        public int GoalId { get; set; }
        public int? UserId { get; set; }
        public string GoalDescription { get; set; } = null!;

       
      
    }
}
