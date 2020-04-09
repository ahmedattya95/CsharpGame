﻿using CsharpGame.Engine.Base;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGame.Engine.Components
{
    public class Tile : Base.GameObject
    {
        public bool Ground { get; set; }
        public Tile(PointF position, Sprite sprite) : base(position, sprite)
        {
            this.Static = true;
            Ground = false;
        }
    }
}
