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



        public User()
        {
            
            Goals = new HashSet<Goal>();
        }

        public int UserId { get; set; }
        public string? Etunimi { get; set; }
        public string? Sukunimi { get; set; }
        public string? Sahkoposti { get; set; }

        //public virtual ICollection<Exercise> Exercises { get; set; }
        public virtual ICollection<Goal> Goals { get; set; }
    }

}

