using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class OutsideWithDoor:Outside, IHasExteriorDoor
    {
        public string DoorDescription
        {
            get;
            private set;
        }

        public Location DoorLocation { get; set; }

        public OutsideWithDoor(string name, bool hot, string doorDesc) : base(name, hot)
        {
            this.DoorDescription = doorDesc;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + DoorDescription + ".";
            }
        }
    }
}
