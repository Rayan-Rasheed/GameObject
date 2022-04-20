﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObject.UI;

namespace GameObject.BL
{
    class Boundary
    {
        public Point TopLeft;
        public Point TopRight;
        public Point BottomLeft;
        public Point BottomRight;
        public Boundary()
        {
            TopLeft = new Point(0, 0);
            TopRight = new Point(90, 0);
            BottomLeft = new Point(0, 90);
            BottomRight = new Point(90, 90);
            
        }
        public Boundary(Point TopLeft, Point BottomLeft,Point TopRight,Point BottomRight) {
            this.TopLeft = TopLeft;
            this.TopRight = TopRight;
            this.BottomLeft = BottomLeft;
            this.BottomRight = BottomRight;
        }
    }
}
