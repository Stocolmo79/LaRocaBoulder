using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Classes
{
    public class User
    {
     
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string nickName { get; set; }
        public bool admin { get; set; }
        public string phone { get; set; }
        public string password { get; set; }
        public string employeenumber { get; set; }
        public int InstructorID { get; set; }
        public string RUT { get; set; }
    }
}
