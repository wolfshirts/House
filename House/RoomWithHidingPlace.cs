﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class RoomWithHidingPlace:Room, IHidingPlace
    {
        public string HidingPlace { get; }

        public RoomWithHidingPlace(string name, string decor, string hidingPlace) : base(name, decor)
        {
            HidingPlace = hidingPlace;
        }

        public override string Description
        {
            get
            {
                return base.Description + " Someone could hide " + HidingPlace + ".";
            }
        }
    }
}
