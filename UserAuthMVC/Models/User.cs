using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAuthMVC.Models
{
    public class User
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public bool LegalAge { get { return Age > 18; } }
    }
}
