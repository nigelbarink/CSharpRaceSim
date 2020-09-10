﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    interface IParticpant
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public IEquipment Equipment { get; set; }
        public TeamColors TeamColor{ get; set; }
    }



    public enum TeamColors
    {
           Red,
           Green,
           Yellow,
           Grey,
           Blue
    };


}