using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXC8JY_OOP_HF
{
    public class User
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Stuff
        {
            get { return Name; }
            set
            {
                string[] stuff = value.Split(',');
                name = stuff[0];
            }
        }
    }
}
