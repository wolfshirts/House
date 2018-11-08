using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Room:Location
    {
        private string decoration;
        public Room(string name, string decor) : base(name)
        {
            decoration = decor;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}
